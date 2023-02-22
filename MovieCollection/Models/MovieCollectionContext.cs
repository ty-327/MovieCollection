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
        public DbSet<Category> Categories { get; set; }


        // Seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category { CategoryID=1, CategoryName="Action"},
                    new Category { CategoryID=2, CategoryName="Adventure"},
                    new Category { CategoryID=3, CategoryName="Comedy"},
                    new Category { CategoryID=4, CategoryName="Romance"},
                    new Category { CategoryID=5, CategoryName="Horror"},
                    new Category { CategoryID=6, CategoryName="Thriller"},
                    new Category { CategoryID=7, CategoryName="Sci-fi"},
                    new Category { CategoryID=8, CategoryName="Fantasy"}
                );

            mb.Entity<EnterMovieModel>().HasData(
                new EnterMovieModel
                {
                    MovieID = 1,
                    CategoryID = 7,
                    Title = "Inception",
                    Year = 2010,
                    Director = "Christopher Nolan",
                    Rating = "PG-13"
                },
                new EnterMovieModel
                {
                    MovieID = 2,
                    CategoryID = 1,
                    Title = "Iron Man",
                    Year = 2008,
                    Director = "Jon Favreau",
                    Rating = "PG-13"
                },
                new EnterMovieModel
                {
                    MovieID = 3,
                    CategoryID = 5,
                    Title = "The Village",
                    Year = 2004,
                    Director = "M. Night Shyamalan",
                    Rating = "PG-13"
                }
            );
        }

    }
}
