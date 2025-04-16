using Microsoft.AspNetCore.Mvc;
using VideoSdkApi.Interfaces;

namespace VideoSdkApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController(IRoomsApi roomsApi) : ControllerBase
    {
        [HttpGet("Rooms")]
        public async Task<IActionResult> GetRooms([FromQuery] int pageNumber)
        {
            var rooms = await roomsApi.GetRooms(pageNumber);
            return Ok(rooms);
        }

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
