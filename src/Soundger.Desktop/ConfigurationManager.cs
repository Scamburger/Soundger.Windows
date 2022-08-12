using System.Text.Json;

namespace Soundger.Desktop;

internal static class ConfigurationManager
{
    const string ConfigFileName = "soundger.properties";

    static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        WriteIndented = true,
    };

    public static async Task<Config> LoadConfigAsync()
    {
        var path = GetConfigPath();
        if (!File.Exists(path))
        {
            await File.WriteAllTextAsync(path, JsonSerializer.Serialize(Config.Default, JsonSerializerOptions));
        }

        var content = await File.ReadAllTextAsync(path);
        return JsonSerializer.Deserialize<Config>(content)!;
    }

    public static async Task SaveConfigAsync(Config config)
    {
        var path = GetConfigPath();
        await File.WriteAllTextAsync(path, JsonSerializer.Serialize(config, JsonSerializerOptions));
    }

    private static string GetConfigPath()
    {
        return Path.Combine(Directory.GetCurrentDirectory(), ConfigFileName); ;
    }

    public class Config
    {
        public string Endpoint { get; set; }

        public string? Token { get; set; } = null;

        public HashSet<string> MusicDirectories { get; set; } = new HashSet<string>();

        public bool SyncEnabled { get; set; } = false;

        public Config()
        {

        }

        public static Config Default => new()
        {
            Endpoint = "http://localhost:9991/",
            MusicDirectories = new string[] { Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) }.ToHashSet(),
            Token = null,
            SyncEnabled = false,
        };
    }
}
