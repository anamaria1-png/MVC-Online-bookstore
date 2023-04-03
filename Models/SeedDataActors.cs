using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;
namespace Online_bookstore.Models;

public static class SeedDataActors
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ActorContext(
             serviceProvider.GetRequiredService<
                 DbContextOptions<ActorContext>>()))
        {
            // Look for any movies.
            if (context.Actor.Any())
            {
                return;   // DB has been seeded
            }
            context.Actor.AddRange(
               new Actor
               {
                   Name = "Kate Winslet",
                   LaunchYear= DateTime.Parse("1997-2-05"),
                   Role = "Protagonist",
                   ReplicaNumbers = 552M
               },


                new Actor
                {
                    Name = "Leonardo Dicaprio",
                    LaunchYear = DateTime.Parse("1997-2-05"),
                    Role = "Protagonist",
                    ReplicaNumbers = 465M
                },
                 new Actor
                 {
                     Name = "Asa Butterfield",
                     LaunchYear = DateTime.Parse("2018-12-08"),
                     Role = "Antagonist",
                     ReplicaNumbers = 312M
                 },
                  new Actor
                  {
                      Name = "Elle Pfanning",
                      LaunchYear = DateTime.Parse("2010-01-11"),
                      Role = "Secondary Role",
                      ReplicaNumbers = 152M
                  }
            );
            context.SaveChanges();
        }
    }
}
