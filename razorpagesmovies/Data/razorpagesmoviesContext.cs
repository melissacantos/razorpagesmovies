#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razorpagesmovies.models;

namespace razorpagesmovies.Data
{
    public class razorpagesmoviesContext : DbContext
    {
        public razorpagesmoviesContext (DbContextOptions<razorpagesmoviesContext> options)
            : base(options)
        {
        }

        public DbSet<razorpagesmovies.models.movie> movie { get; set; }
    }
}
