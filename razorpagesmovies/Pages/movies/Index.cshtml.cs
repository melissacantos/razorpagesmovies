#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorpagesmovies.Data;
using razorpagesmovies.models;

namespace razorpagesmovies.Pages.movies
{
    public class IndexModel : PageModel
    {
        private readonly razorpagesmovies.Data.razorpagesmoviesContext _context;

        public IndexModel(razorpagesmovies.Data.razorpagesmoviesContext context)
        {
            _context = context;
        }

        public IList<movie> movie { get;set; }

        public async Task OnGetAsync()
        {
            movie = await _context.movie.ToListAsync();
        }
    }
}
