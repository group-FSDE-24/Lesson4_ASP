using FirstWebApp.Modelsl;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers;

public class PersonController : Controller
{
    public List<Person> People { get; set; }

    public PersonController()
    {
        People = people;
    }

    public IActionResult Index()
    {
        return View();
    }
}
