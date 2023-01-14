using Microsoft.EntityFrameworkCore;

namespace Music.Data
{
    public class dbContext
    {
        private DbContextOptions<ApplicationDbContext> options;

        public dbContext(DbContextOptions<ApplicationDbContext> options)
        {
            this.options = options;
        }
    }
}
