using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemyProject.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
