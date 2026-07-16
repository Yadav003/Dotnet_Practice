using Microsoft.EntityFrameworkCore;
using Crud_Practice.Models;

namespace Crud_Practice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        }
        public DbSet<Student> Students { get; set; }
    }
}
