using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DI.Models;

namespace DI.Controllers;

public class ServiceController : Controller
{
    private readonly IInfo _iinfo;

    public ServiceController(IInfo iinfo)
    {
        _iinfo = iinfo;
    }

    public IActionResult Index()
    {
        var display = _iinfo.Display();
        return Ok(display);
    }
}