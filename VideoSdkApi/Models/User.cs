using Newtonsoft.Json;

namespace VideoSdkApi.Models;

public class User
{
    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("discontinuedReason")]
    public object DiscontinuedReason { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }
}
