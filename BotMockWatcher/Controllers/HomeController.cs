using BotMockWatcher.Models;
using Microsoft.AspNetCore.Mvc;

namespace BotMockWatcher.Controllers;

public class HomeController : Controller
{
    private static readonly IEnumerable<Element> _elements = Enumerable
        .Range('a', 'z' - 'a' + 1)
        .Select(x => new FolderElement(new string([(char)x]), DateTime.Now))
        .ToList();

    [HttpGet("{*route}")]
    public IActionResult Index(string route)
    {
        ViewBag.Title = "/" + route;

        var viewModel = new ElementView
        {
            Route = route ?? string.Empty,
            Elements = _elements
        };

        return View(viewModel);
    }
}
