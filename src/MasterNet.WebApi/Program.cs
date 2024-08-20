using MasterNet.Application;
using MasterNet.Application.Interfaces;
using MasterNet.Infrastructure.Photos;
using MasterNet.Infrastructure.Reports;
using MasterNet.Persistence;
using MasterNet.WebApi.Extensions;
using MasterNet.WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddIdentityService(builder.Configuration);
builder.Services.AddPoliciesServices();

builder.Services.Configure<CloudinarySettings>(builder.Configuration.GetSection(nameof(CloudinarySettings)));
builder.Services.AddScoped<IPhotoService, PhotoService>();

// builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddScoped(typeof(IReportService<>), typeof(ReportService<>));

builder.Services.AddHttpContextAccessor();

builder.Services.AddControllers();

// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerDocumentation();

builder.Services.AddCors(options =>
{
  options.AddPolicy("CorsPolicy", policy =>
  {
    policy
      .AllowAnyHeader()
      .AllowAnyMethod()
      .WithOrigins("http://localhost:3000");
  });
});

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
  app.UseSwaggerDocumentation();
}

app.UseAuthentication();
app.UseAuthorization();

app.UseCors("CorsPolicy");

await app.SeedDataAuthentication();

// app.UseHttpsRedirection();
app.MapControllers();
app.Run();
