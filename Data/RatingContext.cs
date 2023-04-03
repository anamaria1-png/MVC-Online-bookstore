using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Online_bookstore.Models;

namespace MvcMovie.Data
{
    public class RatingContext : DbContext
    {
        public RatingContext(DbContextOptions<RatingContext> options)
            : base(options)
        {
        }
        public DbSet<Online_bookstore.Models.Rating> Rating { get; set; } = default!;
    }
}
