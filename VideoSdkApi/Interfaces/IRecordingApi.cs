using Microsoft.AspNetCore.Mvc;
using Refit;
using VideoSdkApi.Models;

namespace VideoSdkApi.Interfaces;

public interface IRecordingApi
{
    [Post("/start")]
    Task<string> StartRecording([FromBody] Recording recording);

    [Post("/end")]
    Task<string> StopRecording([FromBody] string roomId);
}
