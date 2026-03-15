using Microsoft.EntityFrameworkCore;
using WebApiFirst.Models;

namespace WebApiFirst.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Character> Characters => Set<Character>();
    }
}
