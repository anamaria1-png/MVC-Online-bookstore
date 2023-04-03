using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Online_bookstore.Models;
using MvcMovie.Models;

namespace Online_bookstore.Data
{
    public class Online_bookstoreContext : DbContext
    {
        public Online_bookstoreContext (DbContextOptions<Online_bookstoreContext> options)
            : base(options)
        {
        }

        public DbSet<Online_bookstore.Models.Actor> Actor { get; set; } = default!;

        public DbSet<Online_bookstore.Models.Employee> Employee { get; set; } = default!;

        public DbSet<Online_bookstore.Models.Rating> Rating { get; set; } = default!;

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
