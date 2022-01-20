namespace RPGHelper.Helpers;

public class ConfigWizard
{
    public ConfigJson? ConfigJson;

    public ConfigWizard()
    {
        var json = string.Empty;
        using var fs = File.OpenRead("config.json");
        using var sr = new StreamReader(fs, new UTF8Encoding(false));
        json = sr.ReadToEnd();
        ConfigJson = JsonConvert.DeserializeObject<ConfigJson>(json);
    }
}