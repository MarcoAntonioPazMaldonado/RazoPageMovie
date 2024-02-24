using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using RazoPageMovie.Data;
using RazorPageMovie.Models;
using System;


namespace RazoPageMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazoPageMovieContext(
            serviceProvider.GetRequiredService <
            DbContextOptions<RazoPageMovieContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException(nameof(context));
                }
                
                if (context.Movie == null)
                {
                    return;
                }

              
   

            }

        }

        
    }
}
