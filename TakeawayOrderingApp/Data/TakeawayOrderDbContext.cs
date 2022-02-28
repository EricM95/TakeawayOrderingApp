using Microsoft.EntityFrameworkCore;

namespace TakeawayOrderingApp.Data
{
    public class TakeawayOrderDbContext : ApplicationDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions)
        : base(default)
        {
        }

    }
}
