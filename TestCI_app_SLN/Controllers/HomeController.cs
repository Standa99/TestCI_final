using Microsoft.AspNetCore.Mvc;

namespace TestCI_app_SLN.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
