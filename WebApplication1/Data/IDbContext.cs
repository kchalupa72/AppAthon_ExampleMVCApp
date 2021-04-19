using System;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public interface IDbContext : IDisposable
    {
        DbContext Instance { get; }
    }
}
