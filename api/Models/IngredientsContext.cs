using Microsoft.EntityFrameworkCore;
using drinkfinder.Controllers;
using drinkfinder.Models;

namespace drinkfinder.Models
{
    public class IngredientsContext : DbContext
    {
        public IngredientsContext(DbContextOptions<IngredientsContext> options) : base(options)
        {
        }


        public DbSet<Ingredient> Ingredients { get; set; }
    }
}