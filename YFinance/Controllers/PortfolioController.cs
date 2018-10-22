using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YFinance.Models;
using YFinance.Services;

namespace YFinance.Controllers
{
    [Authorize]
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;
        private readonly UserManager<IdentityUser> _userManager;

        public PortfolioController(IPortfolioService portfolioService, UserManager<IdentityUser> userManager)
        {
            _portfolioService = portfolioService;
            _userManager = userManager;
        }
        
        // GET
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null) return Challenge();
            
            var snapshots = await _portfolioService.GetSnapshotAsync(currentUser);

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

            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null) return Challenge();

            var successful = await _portfolioService.AddSnapshotAsync(newPortfolio, currentUser);
            if (!successful)
            {
                return BadRequest("Could not add item.");
            }

            return RedirectToAction("Index");
        }

        public string Stocks()
        {
            return "This is the stocks action method...";
        }
    }
}