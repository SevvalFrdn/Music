using Microsoft.EntityFrameworkCore;
using Music.Models;

namespace Music.Data
{
    public class ApplicationDbContext : DbContext
    {
        private DbContextOptions<ApplicationDbContext> options;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Company> Companys { get; set; }
        public virtual DbSet<MusicType> MusicTypes { get; set; }
        public virtual DbSet<Singer> Singers { get; set; }
        public virtual DbSet<Song> Songs { get; set; }

    }
}
