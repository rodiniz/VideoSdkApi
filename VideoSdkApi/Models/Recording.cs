using Newtonsoft.Json;

namespace VideoSdkApi.Models;

public class RecordingConfig
{
    [JsonProperty("layout")]
    public Layout Layout { get; set; }

}

public class Layout
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("theme")]
    public string Theme { get; set; }

    [JsonProperty("mode")]
    public string Mode { get; set; }

    [JsonProperty("quality")]
    public string Quality { get; set; }

    [JsonProperty("orientation")]
    public string Orientation { get; set; }
}

public class Recording
{
    [JsonProperty("roomId")]
    public required string RoomId { get; set; }

    [JsonProperty("preSignedUrl")]
    public string? PreSignedUrl { get; set; }

    [JsonProperty("config")]
    public RecordingConfig Configuration { get; set; }
}
