using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Models;
using DependencyInjection.Services.Abstracts;
using DependencyInjection.Services.Concretes;

namespace DependencyInjection.Controllers;

public class HomeController : Controller
{
    //private ILog _log;

    //public HomeController(ILog log)
    //{
    //    _log = log;
    //}

    public IActionResult Index()
    {
        //_log.Log(); // new ConsoleLog();

        // Db melumat

        //_log.Log();       
        return View();

    }

    public IActionResult Privacy()
    {
        return View();
    }

    // Xususi bir methodda inject etdikde, Atribute vasitesi ile veririk
    public IActionResult Ali([FromServices] ILog log)
    {
        log.Log();

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
