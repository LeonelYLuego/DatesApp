using DatesApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatesApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
