using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using drinkfinder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace drinkfinder.Controllers
{
    [Route("api/drinks")]
    [ApiController]
    public class DrinksController : ControllerBase
    {
        private readonly DrinksContext db;

        public DrinksController(DrinksContext db)
        {
            this.db = db;

            if(this.db.Drinks.Count() == 0){
                
                Ingredient i1 = new Ingredient(){
                    ingredientId = 1,
                    ingredientName = "Gin"
                };
                Ingredient i2 = new Ingredient(){
                    ingredientId = 2,
                    ingredientName = "Lime Juice"
                };
                Ingredient i3 = new Ingredient(){
                    ingredientId = 3,
                    ingredientName = "Simple Syrup"
                };
                

    

                this.db.Drinks.Add(new Drink(){
                    
                    drinkId = 3,
                    drinkName = "Gimlet",
                    drinkInstruction = "Combine gin, limejuice, and simple syrup in a cocktail shaker. Add ice and shake until chilled. Strain into chilled cocktail glass",          
                    drinkIngredients = new List<Ingredient> { i1, i2, i3 }    
                    
                });
                

                    
                };
                this.db.SaveChanges();

                }
        [HttpGet]
        public IActionResult Get(){
            return Ok(db.Drinks);
        }

        [HttpGet("{id}", Name = "GetDrink")]
        public IActionResult GetDrink(int id)
        {
            //try to find correct drink
            var drink = db.Drinks.FirstOrDefault(d => d.drinkId == id);

            //if no drink is found with name, return 404 error
            if (drink == null){
                return NotFound();
            }
            
            return Ok(drink);
        }

        [HttpPost]

        public IActionResult Post([FromBody]Drink drink)
        {
            if (drink == null){
                return BadRequest();
            }

            db.Drinks.Add(drink);
            db.SaveChanges();

            return CreatedAtRoute("GetDrink", new { id = drink.drinkId }, drink );
        }


        [HttpPut]

        public IActionResult Put(int id, [FromBody]Drink drink)
        {
            //validate incoming drink
            if (drink == null || drink.drinkId != id){
                return BadRequest();
            }
            //verify drink is in database
            var drinkToEdit = db.Drinks.FirstOrDefault(b => b.drinkId == id);
            if(drinkToEdit == null)
            {
                return NotFound();
            }
            
            drinkToEdit.drinkName = drink.drinkName;
            drinkToEdit.drinkInstruction = drink.drinkInstruction;

            db.Drinks.Update(drinkToEdit);
            db.SaveChanges();

            return NoContent();
        }
    }
}