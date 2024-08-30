using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers;
public class MinhController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Index(String FullName)
    {
        ViewBag.Message = "Xin chao" + FullName;
        return View();
    }
    
}