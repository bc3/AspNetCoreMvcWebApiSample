using Microsoft.AspNetCore.Mvc;

namespace HWApi.Controllers
{
     [Route("[controller]")]
     public class FooController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}