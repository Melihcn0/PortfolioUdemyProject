using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemyProject.ViewComponents
{
    public class _PhotoswipeComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
