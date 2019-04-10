using System;
using System.Collections.Generic;
using drinkfinder.Controllers;
using drinkfinder.Models;

namespace drinkfinder.Models{

    public class Drink
    {
        internal string drinkInstructions;

        public int drinkId { get; set; }

        public string drinkName { get; set;}

        public string drinkInstruction { get; set; }

        public List<Ingredient> drinkIngredients { get; set; }
    }
}