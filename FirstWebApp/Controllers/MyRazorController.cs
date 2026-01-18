using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers;

public class MyRazorController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
