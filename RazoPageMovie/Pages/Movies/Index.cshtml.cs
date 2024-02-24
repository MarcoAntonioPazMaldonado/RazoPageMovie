using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazoPageMovie.Data;
using RazoPageMovie.Models;

namespace RazoPageMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazoPageMovie.Data.RazoPageMovieContext _context;

        public IndexModel(RazoPageMovie.Data.RazoPageMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
