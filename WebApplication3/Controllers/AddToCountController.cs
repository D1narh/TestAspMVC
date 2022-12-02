using Microsoft.AspNetCore.Mvc;
using WebApplication3.Class;

namespace WebApplication3.Controllers
{
    public class AddToCountController : Controller
    {
        [HttpGet]
        public IActionResult Index(int Count)
        {
            Server.AddToCount(Count);

            return View();
        }
    }
}
