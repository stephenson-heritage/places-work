using Microsoft.EntityFrameworkCore;

namespace places_work.Models
{

    public class MapContext : DbContext
    {
        public MapContext(DbContextOptions<MapContext> options)
            : base(options)
        {
        }

        public DbSet<Place> Game { get; set; }
    }

}