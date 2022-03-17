using LifeFitsHome.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace LifeFitsHome.Contexts
{
    public class DbContextBase : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Claim> Claims { get; set; }
    }
}
