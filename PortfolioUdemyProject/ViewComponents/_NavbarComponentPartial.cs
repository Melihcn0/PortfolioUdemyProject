using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace PortfolioUdemyProject.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
