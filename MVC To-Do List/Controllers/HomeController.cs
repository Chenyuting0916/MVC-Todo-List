using Microsoft.AspNetCore.Mvc;

namespace MVC_To_Do_List.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ITodoService _todoService;

    public HomeController(ILogger<HomeController> logger, ITodoService todoService)
    {
        _logger = logger;
        _todoService = todoService;
    }

    public IActionResult Index()
    {
        var todoLists = _todoService.Get(1);
        return View();
    }
}