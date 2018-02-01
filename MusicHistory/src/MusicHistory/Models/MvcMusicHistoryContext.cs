using Microsoft.EntityFrameworkCore;

namespace MusicHistory.Models
{
    public class MvcMusicHistoryContext : DbContext
    {
        public MvcMusicHistoryContext (DbContextOptions<MvcMusicHistoryContext> options)
            : base(options)
        {
        }

        public DbSet<MusicHistory.Models.Artist> Artist { get; set; }
        public DbSet<MusicHistory.Models.Album> Album { get; set; }
        public DbSet<MusicHistory.Models.Genre> Genre { get; set; }
        public DbSet<MusicHistory.Models.Song> Song { get; set; }
    }
}