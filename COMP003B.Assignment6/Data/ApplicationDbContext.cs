using COMP003B.Assignment6.Models;
using Microsoft.EntityFrameworkCore;


namespace COMP003B.Assignment6.Data
{
    public class ApplicationDbContext : DbContext
    {
        //This is the local database that gets updated 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; } //All of the database sets for the classes
        public DbSet<SongArtist> SongArtists { get; set; }

    }
}
