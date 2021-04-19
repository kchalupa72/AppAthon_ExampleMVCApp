using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDataDbContext : DbContext, IAppDataDbContext
    {
        public AppDataDbContext (DbContextOptions<AppDataDbContext> options)
            : base(options)
        {
        }

        public DbContext Instance => this;
        public DbSet<LoanData> LoanData { get; set; }
    }
}
