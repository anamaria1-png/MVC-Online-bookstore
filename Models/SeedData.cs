using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Titanic",
                    ReleaseDate = DateTime.Parse("190-5-12"),
                    Genre = "Romantic Drama",
                    Price = 10.50M
                },
                new Movie
                {
                    Title = "The Bucket",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 12.30M
                },
                new Movie
                {
                    Title = "Anne with an E",
                    ReleaseDate = DateTime.Parse("2019-1-23"),
                    Genre = "Historical Fiction",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Don't let me go",
                    ReleaseDate = DateTime.Parse("2017-3-9"),
                    Genre = "SF Drama",
                    Price = 23.7M
                }
            );
            context.SaveChanges();
        }
    }
}
