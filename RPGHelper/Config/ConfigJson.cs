using Newtonsoft.Json;

namespace RPGHelper.Config;

public class ConfigJson
{
    [JsonProperty("token")]
    public string Token { get; private set; }
    [JsonProperty("prefix")]
    public string? Prefix { get; private set; }
    [JsonProperty("prefix_whf")] public string Prefix_WHF { get; set; }
}