using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers {get; set;}
        
        public DataContext(DbContextOptions options) : base(options)
        {
        }       
    }
}