using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McCordMission4Take2.Models
{
    public class MovieData : DbContext
    {
        public MovieData (DbContextOptions<MovieData> options) : base(options)
        {
            //leaving this blank rn
        }

        public DbSet<MovieAdd> MovieAdds { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieAdd>().HasData(
                new MovieAdd
                {
                    ApplicationID = 1,
                    Category = "Comedy",
                    Title = "Dodgeball",
                    Director = "Rawson Thurber",
                    Rating = "PG-13",
                    Edited = true,
                    Lent_To = "Connor Meadows",
                    Note = "This movie has been watched many a times in Newport Hills"
                },
                new MovieAdd
                {
                    ApplicationID = 2,
                    Category = "Romantic-Comedy",
                    Title = "Crazy Rich Asians",
                    Director = "Jon M. Chu",
                    Rating = "PG-13",
                    Edited = false,
                },
                new MovieAdd
                {
                    ApplicationID = 3,
                    Category = "Animation",
                    Title = "Mulan",
                    Director = "Jon M. Chu",
                    Rating = "PG"
                });
        }
    }
}
