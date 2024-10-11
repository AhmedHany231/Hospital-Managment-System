using Microsoft.AspNetCore.Mvc;

namespace Hospital.web.Areas.Patient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
