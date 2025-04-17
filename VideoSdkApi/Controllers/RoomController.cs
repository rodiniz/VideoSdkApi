using Microsoft.AspNetCore.Mvc;
using VideoSdkApi.Interfaces;

namespace VideoSdkApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController(IRoomsApi roomsApi) : ControllerBase
    {
        [HttpPost("CreateRoom")]
        public async Task<IActionResult> CreateRoom()
        {
            var rooms = await roomsApi.CreateRoom();
            return Ok(rooms);
        }

        [HttpGet("Validate/{roomId}")]
        public async Task<IActionResult> Validate(string roomId)
        {
            var rooms = await roomsApi.Validate(roomId);
            return Ok(rooms);
        }
    }
}
