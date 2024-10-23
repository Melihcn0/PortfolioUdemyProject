using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemyProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
