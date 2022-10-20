using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Laborator2.Data;
using Laborator2.Models;

namespace Laborator2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Laborator2.Data.Laborator2Context _context;

        public IndexModel(Laborator2.Data.Laborator2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
           .Include(b => b.Publisher)
           .ToListAsync();
        }
    }
}
