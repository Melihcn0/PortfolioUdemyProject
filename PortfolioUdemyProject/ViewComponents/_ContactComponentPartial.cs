using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemyProject.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
