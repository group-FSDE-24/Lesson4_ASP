using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
