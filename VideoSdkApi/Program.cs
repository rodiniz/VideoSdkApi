using Refit;
using Scalar.AspNetCore;
using VideoSdkApi;
using VideoSdkApi.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


builder.Services
    .AddRefitClient<IRoomsApi>()
    .ConfigureHttpClient(c =>
    {
        c.DefaultRequestHeaders.Add("Authorization", Helpers.GenerateToken());
        c.BaseAddress = new Uri("https://api.videosdk.live/v2/rooms");
    });

builder.Services
    .AddRefitClient<IRecordingApi>()
    .ConfigureHttpClient(c =>
    {
        c.DefaultRequestHeaders.Add("Authorization", Helpers.GenerateToken());
        c.BaseAddress = new Uri("https://api.videosdk.live/v2/recordings");
    });



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
