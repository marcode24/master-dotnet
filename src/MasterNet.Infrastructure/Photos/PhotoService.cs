using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using MasterNet.Application.Interfaces;
using MasterNet.Application.Photos;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace MasterNet.Infrastructure.Photos;

public class PhotoService : IPhotoService
{
  private readonly Cloudinary _cloudinary;

  public PhotoService(IOptions<CloudinarySettings> config)
  {
    var account = new Account(
        config.Value.CloudName,
        config.Value.ApiKey,
        config.Value.ApiSecret
    );
    _cloudinary = new Cloudinary(account);
  }

  public async Task<PhotoUploadResult> AddPhoto(IFormFile file)
  {
    if (file.Length > 0)
    {
      await using var stream = file.OpenReadStream();
      var uploadParams = new ImageUploadParams
      {
        File = new FileDescription(file.FileName, stream),
        Transformation = new Transformation().Height(500).Width(500).Crop("fill"),
      };

      var uploadResult = await _cloudinary.UploadAsync(uploadParams);

      if (uploadResult.Error is not null)
        throw new Exception(uploadResult.Error.Message);

      return new PhotoUploadResult
      {
        PublicId = uploadResult.PublicId,
        Url = uploadResult.SecureUrl.ToString(),
      };
    }

    return null!;
  }

  public async Task<string> DeletePhoto(string publicId)
  {
    var deleteParams = new DeletionParams(publicId);
    var result = await _cloudinary.DestroyAsync(deleteParams);

    return result.Result.Equals("ok") ? result.Result! : null!;
  }
}