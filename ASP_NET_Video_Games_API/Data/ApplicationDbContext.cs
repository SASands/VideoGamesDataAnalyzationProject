using ASP_NET_Video_Games_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_NET_Video_Games_API.Data
{
    public class ApplicationDbContext : DbContext // <-inhereting from Class in Dependencies
    {
        
        
        
        public DbSet<VideoGame> VideoGames { get; set; } // in order for our migrations to turn the VideoGame Model into a Table, You have to turn a model into a DbSet 



        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}


//DbContext is essentially the portal into the database