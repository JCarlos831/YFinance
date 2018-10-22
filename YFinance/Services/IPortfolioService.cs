using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using YFinance.Models;

namespace YFinance.Services
{
    public interface IPortfolioService
    {
        Task<Portfolio[]> GetSnapshotAsync(IdentityUser user);
        
        Task<bool> AddSnapshotAsync(Portfolio newPortfolio, IdentityUser user);

    }
}