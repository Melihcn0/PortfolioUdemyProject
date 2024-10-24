using Microsoft.AspNetCore.Mvc;
using PortfolioUdemyProject.DataAccessLayer.Context;

namespace PortfolioUdemyProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.ToDoListCount = portfolioContext.ToDoLists.Where(x => x.Status == false).Count();
            var values = portfolioContext.ToDoLists.Where(x => x.Status == false).ToList();
            return View(values);
        }
    }
}
