using Microsoft.EntityFrameworkCore;
using WebApplication2.Domain;

namespace WebApplication2
{
    public class AppDb : DbContext
    {
        protected AppDb()
        {
        }

        public AppDb(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<User> Users { get; protected set; }
    }
}