using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dependencies.Models;

namespace Dependencies.Controllers;

public class ServiceController : Controller
{
    private readonly IInfo _IInfo;

    public ServiceController(IInfo iinfo)
    {
        _IInfo = iinfo;
    }

    public IActionResult Index()
    {
        var data = _IInfo.Display();
        return Ok(data);
    }
}
