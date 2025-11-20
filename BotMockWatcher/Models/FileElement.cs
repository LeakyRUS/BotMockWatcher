namespace BotMockWatcher.Models;

public record FileElement(ElementType Type, string Name, DateTime LastModified, int SizeBytes)
    : Element(Type, Name, LastModified)
{
    public override string Size { get; } = SizeBytes switch
    {
        < 1024 => $"{SizeBytes}B",
        < 1024 * 1024 => $"{SizeBytes / 1024}K",
        < 1024 * 1024 * 1024 => $"{SizeBytes / 1024 / 1024}M",
        _ => $"{SizeBytes / 1024 / 1024 / 1024}G"
    };
}
