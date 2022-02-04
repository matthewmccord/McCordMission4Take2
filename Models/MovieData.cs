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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Comedy" },
                new Category { CategoryID = 2, CategoryName = "Romantic-Comedy" },
                new Category { CategoryID = 3, CategoryName = "Animation" },
                new Category { CategoryID = 4, CategoryName = "Drama" }
                );
            
            mb.Entity<MovieAdd>().HasData(
                new MovieAdd
                {
                    MovieID = 1,
                    CategoryID = 1,
                    Title = "Dodgeball",
                    Director = "Rawson Thurber",
                    Rating = "PG-13",
                    Edited = true,
                    Lent_To = "Connor Meadows",
                    Note = "This movie has been watched many a times in Newport Hills"
                },
                new MovieAdd
                {
                    MovieID = 2,
                    CategoryID = 2,
                    Title = "Crazy Rich Asians",
                    Director = "Jon M. Chu",
                    Rating = "PG-13",
                    Edited = false,
                },
                new MovieAdd
                {
                    MovieID = 3,
                    CategoryID = 3,
                    Title = "Mulan",
                    Director = "Jon M. Chu",
                    Rating = "PG"
                });
        }
    }
}
