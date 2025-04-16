using Newtonsoft.Json;

namespace VideoSdkApi.Models;

public class Links
{
    [JsonProperty("get_room")]
    public string GetRoom { get; set; }

    [JsonProperty("get_session")]
    public string GetSession { get; set; }
}