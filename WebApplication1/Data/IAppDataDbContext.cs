using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public interface IAppDataDbContext : IDbContext
    {
        DbSet<LoanData> LoanData { get; set; }
    }
}
