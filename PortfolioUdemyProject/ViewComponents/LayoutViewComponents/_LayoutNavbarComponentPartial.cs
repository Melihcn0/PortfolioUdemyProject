using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemyProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
