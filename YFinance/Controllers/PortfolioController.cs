using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YFinance.Models;
using YFinance.Services;

namespace YFinance.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }
        
        // GET
        public async Task<IActionResult> Index()
        {
            var snapshots = await _portfolioService.GetSnapshotAsync();

            var model = new PortfolioViewModel()
            {
                Snapshots = snapshots
            };

            return View(model);
        }
        
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSnapshot(Portfolio newPortfolio)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var successful = await _portfolioService.AddSnapshotAsync(newPortfolio);
            if (!successful)
            {
                return BadRequest("Could not add item.");
            }

            return RedirectToAction("Index");
        }
    }
}