using Microsoft.AspNetCore.Mvc;
using VideoSdkApi.Interfaces;
using VideoSdkApi.Models;

namespace VideoSdkApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RecordingController(IRecordingApi recordingApi) : ControllerBase
{
    [HttpPost("Start")]
    public async Task<IActionResult> StartRecorging(string roomId, string recordingMode = "video-and-audio")
    {
        var recordingConfig = new Recording
        {
            RoomId = roomId,
            Configuration = new RecordingConfig
            {
                Layout = new Layout
                {
                    Type = "GRID",
                    Theme = "LIGHT",
                    Mode = recordingMode,
                    Quality = "high",
                    Orientation = "landscape"
                }
            }
        };

        var status = await recordingApi.StartRecording(recordingConfig);
        return status == "Recording started successfully" ? Ok() : BadRequest();
    }

    [HttpPost("End")]
    public async Task<IActionResult> EndRecorging(string roomId)
    {
        var status = await recordingApi.StopRecording(roomId);
        return status == "Recording ended successfully" ? Ok() : BadRequest();
    }
}
