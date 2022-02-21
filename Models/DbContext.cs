using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment_3_New.Models
{
    public class GroceryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GroceryDatabase.db");
        }
        public GroceryContext (DbContextOptions<GroceryContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Driver> Drivers {get; set;}
        public DbSet<Order> Orders {get; set;}

        public async virtual Task AddCustomerAsync(Customer customer)
        {
            await Customers.AddAsync(customer);
            await SaveChangesAsync();
        }
    }
}