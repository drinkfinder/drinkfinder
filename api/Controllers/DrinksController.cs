using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using drinkfinder.Models;
using Microsoft.AspNetCore.Mvc;


namespace drinkfinder.Controllers
{
    [Route("api/drinks")]
    [ApiController]
    public class DrinksController : ControllerBase
    {
        private readonly DrinkContext db;

        public DrinksController(DrinkContext db)
        {
            this.db = db;

            if(this.db.Drinks.Count() == 0){
                Drink newDrink1 = new Drink(){
                    drinkId = 1,
                    drinkName = "Manhattan",
                    drinkInstructions = "Stir the rye, vermouth, and bitters well with cracked ice. Strain into a chilled cocktail glass and garnish with a twist or a maraschino cherry.",
    //havent completed logic for ingredients          

                    };
                };

                }

                }
            }