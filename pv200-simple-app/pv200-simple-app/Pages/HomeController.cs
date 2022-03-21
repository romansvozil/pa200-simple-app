using Microsoft.AspNetCore.Mvc;

namespace pv200_simple_app.Pages
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string name = "Makrel";
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["name"]))
                name = HttpContext.Request.Query["name"];

            return Content("Name from query string: " + name);
        }
    }
}
