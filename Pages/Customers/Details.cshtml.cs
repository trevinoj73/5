using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Assignment_3_New.Models;

namespace Assignment_3_New.Pages_Customers
{
    public class DetailsModel : PageModel
    {
        private readonly Assignment_3_New.Models.GroceryContext _context;

        public DetailsModel(Assignment_3_New.Models.GroceryContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers.FirstOrDefaultAsync(m => m.customerID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
