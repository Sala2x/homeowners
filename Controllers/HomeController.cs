using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ELNET.Models;

namespace ELNET.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    // ✅ New method to serve the Announcements page
    public IActionResult Announcement()
    {
        return View();  // This returns the "announcement.cshtml" view inside Views/Home/
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
