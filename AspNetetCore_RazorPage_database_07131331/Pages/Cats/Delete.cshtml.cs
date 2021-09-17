using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetetCore_RazorPage_database_07131331.Data;
using AspNetetCore_RazorPage_database_07131331.Models;

namespace AspNetetCore_RazorPage_database_07131331
{
    public class DeleteModel : PageModel
    {
        private readonly AspNetetCore_RazorPage_database_07131331.Data.AspNetetCore_RazorPage_database_07131331Context _context;

        public DeleteModel(AspNetetCore_RazorPage_database_07131331.Data.AspNetetCore_RazorPage_database_07131331Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Cat Cat { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cat = await _context.Cat.FirstOrDefaultAsync(m => m.ID == id);

            if (Cat == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cat = await _context.Cat.FindAsync(id);

            if (Cat != null)
            {
                _context.Cat.Remove(Cat);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
