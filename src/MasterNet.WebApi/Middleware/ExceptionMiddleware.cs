using System.Net;
using System.Text.Json;
using MasterNet.Application.Core;
using Newtonsoft.Json;

namespace MasterNet.WebApi.Middleware;

public class ExceptionMiddleware
{
  private readonly RequestDelegate _next;
  private readonly ILogger<ExceptionMiddleware> _logger;
  private readonly IHostEnvironment _env;

  public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IHostEnvironment env)
  {
    _next = next;
    _logger = logger;
    _env = env;
  }

  public async Task InvokeAsync(HttpContext context)
  {
    try
    {
      await _next(context);
    }
    catch (Exception ex)
    {
      // _logger.LogError(ex, ex.Message);
      // context.Response.ContentType = "application/json";
      // context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

      // var response = _env.IsDevelopment()
      //   ? new AppException((int)HttpStatusCode.InternalServerError, ex.Message, ex.StackTrace?.ToString())
      //   : new AppException((int)HttpStatusCode.InternalServerError, "Internal Server Error", null);

      // var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
      // var json = JsonSerializer.Serialize(response, options);

      // await context.Response.WriteAsync(json);
      _logger.LogError(ex, ex.Message);
      var response = ex switch
      {
        ValidationException validation => new AppException(
          (int)HttpStatusCode.BadRequest,
          "Validation errors occurred",
          string.Join(",", validation.Errors.Select(e => e.ErrorMessage))
        // JsonConvert.SerializeObject(validation.Errors.ToArray())
        ),
        _ => new AppException(
          (int)HttpStatusCode.InternalServerError,
          _env.IsDevelopment() ? ex.Message : "Internal Server Error",
          _env.IsDevelopment() ? ex.StackTrace?.ToString() : null
        )
      };

      context.Response.StatusCode = response.StatusCode;
      context.Response.ContentType = "application/json";
      var json = JsonConvert.SerializeObject(response);

      await context.Response.WriteAsync(json);
    }
  }
}