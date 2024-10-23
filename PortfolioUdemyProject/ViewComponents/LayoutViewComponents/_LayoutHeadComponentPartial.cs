using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemyProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {  
            return View(); 
        }
    }
}
