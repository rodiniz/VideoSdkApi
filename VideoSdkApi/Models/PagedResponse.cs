using Newtonsoft.Json;

namespace VideoSdkApi.Models;

public class PageInfo
{
    [JsonProperty("currentPage")]
    public int CurrentPage { get; set; }

    [JsonProperty("perPage")]
    public int PerPage { get; set; }

    [JsonProperty("lastPage")]
    public int LastPage { get; set; }

    [JsonProperty("total")]
    public int Total { get; set; }
}

public class PagedResponse<T>
{
    [JsonProperty("pageInfo")]
    public PageInfo PageInfo { get; set; }

    [JsonProperty("data")]
    public List<T> Data { get; set; }
}