using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using drinkfinder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace drinkfinder.Controllers
{
    [Route("api/ingredients")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IngredientsContext idb;

        public IngredientsController(IngredientsContext idb)
        {
            this.idb = idb;

            if(this.idb.Ingredients.Count() == 0){
                
                this.idb.Ingredients.Add(new Ingredient(){
                    
                    ingredientId = 1,
                    ingredientName = "Vodka"
                    
                });
                this.idb.Ingredients.Add(new Ingredient(){
                    
                    ingredientId = 2,
                    ingredientName = "Gin"
                    
                });
                this.idb.Ingredients.Add(new Ingredient(){
                    
                    ingredientId = 3,
                    ingredientName = "Whiskey"
                    
                });
                

                    
                };
                this.idb.SaveChanges();

                }
        [HttpGet]
        public IActionResult Get(){
            return Ok(idb.Ingredients);
        }

        [HttpGet("{id}", Name = "GetIngredient")]
        public IActionResult GetDrink(int id)
        {
            //try to find correct ingredient
            var ingredient = idb.Ingredients.FirstOrDefault(d => d.ingredientId == id);

            //if no ingredient is found with name, return 404 error
            if (ingredient == null){
                return NotFound();
            }
            
            return Ok(ingredient);
        }

        [HttpPost]

        public IActionResult Post([FromBody]Ingredient ingredient)
        {
            if (ingredient == null){
                return BadRequest();
            }

            idb.Ingredients.Add(ingredient);
            idb.SaveChanges();

            return CreatedAtRoute("GetIngredient", new { id = ingredient.ingredientId }, ingredient );
        }

        
        [HttpPut]

        public IActionResult Put(int id, [FromBody]Ingredient ingredient)
        {
            //validate incoming ingredient
            if (ingredient == null || ingredient.ingredientId != id){
                return BadRequest();
            }
            //verify drink is in database
            var ingredientToEdit = idb.Ingredients.FirstOrDefault(b => b.ingredientId == id);
            if(ingredientToEdit == null)
            {
                return NotFound();
            }
            
            ingredientToEdit.ingredientName = ingredient.ingredientName;

            idb.Ingredients.Update(ingredientToEdit);
            idb.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            var ingredient = idb.Ingredients.FirstOrDefault(b => b.ingredientId == id);

            if( ingredient == null){
                return NotFound();
            }

            idb.Ingredients.Remove(ingredient);
            idb.SaveChanges();

            return NoContent();
        }

    }
}