using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models
{
    public class MovieCollectionContext : DbContext //inherit from general (parent) DbContext file
    {
        //constructor
        public MovieCollectionContext () 
        {
            
        }
        public MovieCollectionContext (DbContextOptions<MovieCollectionContext> options) : base (options) //inheriting base options
        {
            //leave blank for now
        }

        public DbSet<EnterMovieModel> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<EnterMovieModel>().HasData(
                new EnterMovieModel
                {
                    MovieID = 1,
                    Category = "Sci-Fi",
                    Title = "Inception",
                    Year = 2010,
                    Director = "Christopher Nolan",
                    Rating = "PG-13"
                },
                new EnterMovieModel
                {
                    MovieID = 2,
                    Category = "SuperHero",
                    Title = "Iron Man",
                    Year = 2008,
                    Director = "Jon Favreau",
                    Rating = "PG-13"
                },
                new EnterMovieModel
                {
                    MovieID = 3,
                    Category = "Horror",
                    Title = "The Village",
                    Year = 2004,
                    Director = "M. Night Shyamalan",
                    Rating = "PG-13"
                }
            );
        }

    }
}
