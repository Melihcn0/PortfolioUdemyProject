using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemyProject.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
