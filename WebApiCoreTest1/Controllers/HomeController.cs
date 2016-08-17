using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication
{
    public class HomeController : Controller
    {
        [HttpGet("/{name}")]
        public IActionResult Index(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}