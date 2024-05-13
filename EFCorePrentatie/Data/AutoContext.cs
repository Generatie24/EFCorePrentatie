using EFCorePrentatie.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCorePrentatie.Data
{
    public class AutoContext : DbContext
    {
        public AutoContext(DbContextOptions<AutoContext> options) : base(options)
        {
        }

        public DbSet<Auto> Autos { get; set; }
    }
}
