using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspNetetCore_RazorPage_database_07131331.Data;
using AspNetetCore_RazorPage_database_07131331.Models;

namespace AspNetetCore_RazorPage_database_07131331
{
    public class CreateModel : PageModel
    {
        private readonly AspNetetCore_RazorPage_database_07131331.Data.AspNetetCore_RazorPage_database_07131331Context _context;

        public CreateModel(AspNetetCore_RazorPage_database_07131331.Data.AspNetetCore_RazorPage_database_07131331Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cat Cat { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cat.Add(Cat);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
