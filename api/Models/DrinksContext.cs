using Microsoft.EntityFrameworkCore;
using drinkfinder.Controllers;
using drinkfinder.Models;

namespace drinkfinder.Models
{
    public class DrinksContext : DbContext
    {
        public DrinksContext(DbContextOptions<DrinksContext> options) : base(options)
        {
        }


        public DbSet<Drink> Drinks { get; set; }
    }
}