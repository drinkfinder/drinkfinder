using Microsoft.EntityFrameworkCore;
using drinkfinder.Controllers;
using drinkfinder.Models;

namespace drinkfinder.Models
{
    public class DrinkContext : DbContext
    {
        public DrinkContext(DbContextOptions<DrinkContext> options) : base(options)
        {
        }


        public DbSet<DrinkContext> Drinks { get; set; }
    }
}