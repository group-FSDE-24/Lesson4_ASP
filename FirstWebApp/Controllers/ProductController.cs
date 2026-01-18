using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers;

public class ProductController : Controller
{
    public IActionResult Index() 
    {
        return View();
    }

    public IActionResult Detail()
    {
        return View();
    }

    public IActionResult GetAllProduct()
    {
        return View();
    }
}
