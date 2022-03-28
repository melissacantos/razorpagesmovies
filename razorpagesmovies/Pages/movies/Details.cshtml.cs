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
    public class DetailsModel : PageModel
    {
        private readonly razorpagesmovies.Data.razorpagesmoviesContext _context;

        public DetailsModel(razorpagesmovies.Data.razorpagesmoviesContext context)
        {
            _context = context;
        }

        public movie movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            movie = await _context.movie.FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
