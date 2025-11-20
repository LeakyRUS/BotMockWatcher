namespace BotMockWatcher.Models;

public record FolderElement(string Name, DateTime LastModified)
    : Element(ElementType.Folder, Name, LastModified)
{
    public override string Name { get => base.Name + "/"; set => base.Name = value; }
}
