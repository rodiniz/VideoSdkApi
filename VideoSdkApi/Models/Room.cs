using Newtonsoft.Json;

namespace VideoSdkApi.Models;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Room
{
    [JsonProperty("roomId")]
    public string RoomId { get; set; }

    [JsonProperty("customRoomId")]
    public string CustomRoomId { get; set; }

    [JsonProperty("disabled")]
    public bool Disabled { get; set; }

    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("updatedAt")]
    public DateTime UpdatedAt { get; set; }

    [JsonProperty("user")]
    public User User { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("links")]
    public Links Links { get; set; }
}







