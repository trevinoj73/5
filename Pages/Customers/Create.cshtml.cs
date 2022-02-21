using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Assignment_3_New.Models;

namespace Assignment_3_New.Pages_Customers
{
    public class CreateModel : PageModel
    {
        private readonly Assignment_3_New.Models.GroceryContext _context;

        public CreateModel(Assignment_3_New.Models.GroceryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _context.AddCustomerAsync(Customer);

            return RedirectToPage("./Index");
        }
    }
}
