using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _IConfig;

    public HomeController(ILogger<HomeController> logger, IConfiguration IConfig)
    {
        _logger = logger;
        _IConfig = IConfig;
    }

    // public IActionResult Index()
    // {
        // var appName = _IConfig.GetSection("Application");
        // var appVersion = _IConfig.GetSection("Version");
        // return Ok($"appname:{appName.Value}, appVersion: {appVersion.Value}");
    // }

    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
