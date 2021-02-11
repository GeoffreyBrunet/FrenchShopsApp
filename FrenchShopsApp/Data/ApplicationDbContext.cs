using FrenchShopsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FrenchShopsApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<T_Shop> T_Shop { get; set; }
    }
}
