using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class LoanDataRepository : IRepository<LoanData>
    {
        public IEnumerable<LoanData> List => GetAll().Result;
        
        IAppDataDbContext DbContext;

        public LoanDataRepository(IAppDataDbContext appDataDbContext)
        {
            DbContext = appDataDbContext;
        }

        public async Task<IEnumerable<LoanData>> GetAll()
        {
            return await DbContext.LoanData.ToListAsync().ConfigureAwait(false);
        }


        public async Task Add(LoanData loanData)
        {
            DbContext.Instance.Add(loanData);
            await DbContext.Instance.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task Delete(LoanData loanData)
        {
            DbContext.LoanData.Remove(loanData);
            await DbContext.Instance.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<LoanData> FindById(Guid? id)
        {
           return await DbContext.LoanData.FirstOrDefaultAsync(m => m.Id == id).ConfigureAwait(false);                    
        }

        public async Task Update(LoanData loanData)
        {
            DbContext.Instance.Update(loanData);
            await DbContext.Instance.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
