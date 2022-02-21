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
    public class IndexModel : PageModel
    {
        private readonly Assignment_3_New.Models.GroceryContext _context;

        public IndexModel(Assignment_3_New.Models.GroceryContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
