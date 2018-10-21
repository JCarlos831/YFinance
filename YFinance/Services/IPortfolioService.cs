using System.Threading.Tasks;
using YFinance.Models;

namespace YFinance.Services
{
    public interface IPortfolioService
    {
        Task<Portfolio[]> GetSnapshotAsync();
        
        Task<bool> AddSnapshotAsync(Portfolio newPortfolio);

    }
}