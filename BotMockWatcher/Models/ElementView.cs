namespace BotMockWatcher.Models;

public class ElementView
{
    public string Route { get; set; } = string.Empty;
    public IEnumerable<Element> Elements { get; set; } = [];
}
