using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemyProject.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperienceList()
        {
            return View();
        }
    }
}
