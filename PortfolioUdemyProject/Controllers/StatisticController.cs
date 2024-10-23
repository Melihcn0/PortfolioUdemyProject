using Microsoft.AspNetCore.Mvc;
using PortfolioUdemyProject.DataAccessLayer.Context;

namespace PortfolioUdemyProject.Controllers
{
    public class StatisticController : Controller
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.SkillsCount = portfolioContext.Skills.Count();
            ViewBag.MessageCount = portfolioContext.Messages.Count();
            ViewBag.NotReadMessageCount = portfolioContext.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.ReadMessageCount = portfolioContext.Messages.Where(x => x.IsRead == true).Count();
            return View();
        }
    }
}
