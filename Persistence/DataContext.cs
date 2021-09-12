using Microsoft.EntityFrameworkCore;
using Domain;
namespace Persistence
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Activity> Activities { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }


    }
}