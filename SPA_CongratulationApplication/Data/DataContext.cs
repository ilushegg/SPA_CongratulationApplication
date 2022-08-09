using Microsoft.EntityFrameworkCore;
using SPA_CongratulationApplication.Models;

namespace SPA_CongratulationApplication.Data
{
    public class DataContext : DbContext
    {
        private DataContext(DbContextOptions<DataContext> options) : base(options) { }
    
        public DbSet<Person> People { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
