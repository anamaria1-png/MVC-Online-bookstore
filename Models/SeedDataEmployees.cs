using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;
namespace Online_bookstore.Models;

public static class SeedDataEmployees { 
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new EmployeeContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<EmployeeContext>>()))
        {
            // Look for any movies.
            if (context.Employee.Any())
            {
                return;   // DB has been seeded
            }
            context.Employee.AddRange(
               new Employee
               {
                   Name = "Eliza Elton",
                   BirthDate = DateTime.Parse("1988-2-12"),
                   Job = "Scenarist",
                   Salary = 5250.7M
               },
                 new Employee
                 {
                     Name = "Cash Sally",
                     BirthDate = DateTime.Parse("1963-12-12"),
                     Job = "Lighting",
                     Salary = 3700.7M
                 },
                  new Employee
                  {
                      Name = "Jelly Roger",
                      BirthDate = DateTime.Parse("1955-12-9"),
                      Job = "Make up",
                      Salary = 1300.7M
                  },
                new Employee
                {
                    Name = "Sam John",
                    BirthDate = DateTime.Parse("1977-3-9"),
                    Job = "Regizor",
                    Salary = 2300.7M
                }
            );
            context.SaveChanges();
        }
    }
}
