using FirstWebApp.Helpers;
using FirstWebApp.Models;
using FirstWebApp.MyModel;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers;

/*

View-a data gondermeyin yollari:

1. Model        => Datalari front terefe gonderirik. Modele uygun olaraq Frontda da gerek deyek ne olacaq
2. ViewData
3. ViewBag
4. TempData
 
*/


public class PersonController : Controller
{
    public List<Person> People { get; set; }
    public RuslanExample RuslanExample { get; set; }

    public PersonController()
    {
        People = PersonHelper.GetPeople();
        RuslanExample = new RuslanExample()
        {
            People = PersonHelper.GetPeople(),
            Cars = new List<Car>()
            {
                new Car(){Id = Guid.NewGuid(), Maker = "Kia", Model = "Sorento"},
                new Car(){Id = Guid.NewGuid(), Maker = "Kia", Model = "K5"},
            }
        };
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetPeople()
    {
        return View(People);
    }

    public IActionResult GetRuslanStyle()
    {
        return View(RuslanExample);
    }
}
