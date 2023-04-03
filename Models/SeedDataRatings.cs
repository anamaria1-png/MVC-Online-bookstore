using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;
namespace Online_bookstore.Models;

public static class SeedDataRatings
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RatingContext(
             serviceProvider.GetRequiredService<
                 DbContextOptions<RatingContext>>()))
        {
            // Look for any movies.
            if (context.Rating.Any())
            {
                return;   // DB has been seeded
            }
            context.Rating.AddRange(
               new Rating
               {
                   Name = "Bill Johnny",
                   ReviewDate = DateTime.Parse("2023-2-10"),
                   Review = "Extraordinary and thoughtfull!",
                   StarsNumber = 5M
               },
                new Rating
                {
                   Name = "Sara Parker",
                    ReviewDate = DateTime.Parse("2023-8-15"),
                    Review = "Boring and dull",
                    StarsNumber = 1M
                },
                 new Rating
                 {
                     Name = "Mess Jessica",
                     ReviewDate = DateTime.Parse("2023-2-10"),
                     Review = "Okay but it could have been better..",
                     StarsNumber = 3.5M
                 },
                  new Rating
                  {
                      Name = "Jolly Paul",
                      ReviewDate = DateTime.Parse("2023-4-09"),
                      Review = "Very good acting, but the plot is twisted ",
                      StarsNumber = 4.3M
                  }
                );
            context.SaveChanges();
        }
    }
}
