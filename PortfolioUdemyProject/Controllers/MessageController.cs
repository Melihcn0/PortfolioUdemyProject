using Microsoft.AspNetCore.Mvc;
using PortfolioUdemyProject.DataAccessLayer.Context;
using PortfolioUdemyProject.DataAccessLayer.Entities;

namespace PortfolioUdemyProject.Controllers
{
    public class MessageController : Controller
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IActionResult Inbox()
        {
            var values = portfolioContext.Messages.ToList();
            return View(values);
        }
        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = portfolioContext.Messages.Find(id);
            value.IsRead = true;
            portfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult ChangeIsReadToFalse(int id)
        {
            var value = portfolioContext.Messages.Find(id);
            value.IsRead = false;
            portfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult DeleteMessage(int id)
        {
            var value = portfolioContext.Messages.Find(id);
            portfolioContext.Remove(value);
            portfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult DetailMessage(int id)
        {
            var value = portfolioContext.Messages.Find(id);
            return View(value);
        }
    }
}
