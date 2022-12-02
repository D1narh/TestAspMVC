using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Class;

namespace WebApplication3.Controllers
{
    public class GetCountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int Count()
        {
            return Server.GetCount();
        }
    }
}
