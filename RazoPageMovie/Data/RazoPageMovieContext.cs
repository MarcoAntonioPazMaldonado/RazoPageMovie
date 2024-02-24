using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazoPageMovie.Models;

namespace RazoPageMovie.Data
{
    public class RazoPageMovieContext : DbContext
    {
        public RazoPageMovieContext (DbContextOptions<RazoPageMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazoPageMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
