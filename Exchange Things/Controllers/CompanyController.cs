using Microsoft.AspNetCore.Mvc;

namespace Exchange_Things.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
