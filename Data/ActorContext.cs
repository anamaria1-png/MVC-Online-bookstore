using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Online_bookstore.Models;

namespace MvcMovie.Data
{
    public class ActorContext : DbContext
    {
        public ActorContext(DbContextOptions<ActorContext> options)
            : base(options)
        {
        }
        public DbSet<Online_bookstore.Models.Actor> Actor { get; set; } = default!;
    }
}
