using Microsoft.AspNetCore.Mvc;

public class DocumentsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
