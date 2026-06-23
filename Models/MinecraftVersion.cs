namespace HeardGreenLauncher.Models;

public class MinecraftVersion
{
    public string Id { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public DateTime ReleaseTime { get; set; }
}

public class VersionManifest
{
    public List<MinecraftVersion> Versions { get; set; } = new();
}