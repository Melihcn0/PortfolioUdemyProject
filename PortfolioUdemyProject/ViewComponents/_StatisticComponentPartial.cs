using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemyProject.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
