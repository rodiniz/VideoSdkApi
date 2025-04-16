using Refit;
using VideoSdkApi.Models;

namespace VideoSdkApi.Interfaces;

public interface IRoomsApi
{

    [Get("/page={page}&perPage=20")]
    Task<PagedResponse<Room>> GetRooms([AliasAs("page")] int page);

    [Post("")]
    Task<Room> CreateRoom();

    [Get("/validate/{roomId}")]
    Task<Room> Validate([AliasAs("roomId")] string roomId);
}
