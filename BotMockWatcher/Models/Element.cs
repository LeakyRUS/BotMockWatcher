namespace BotMockWatcher.Models;

public record Element(ElementType Type, string Name, DateTime LastModified)
{
    public virtual string Name { get; set; } = Name;
    public virtual string Size { get; } = "-";
}
