using System;
using System.Collections.Generic;
using drinkfinder.Controllers;

namespace drinkfinder.Models{

    public class Drink
    {
        public List<Drink> drinkList { get; set; }
        public int currentPosition = 0;
        
        public int drinkId { get; set; }
        public string drinkName { get; set; }

        public string drinkInstructions { get; set; }

        public List<Ingredient> ingredientList { get; set;}


        //need to add ingredient list as a parameter or a way to create ingredients from here
        public void addDrink(string incomingName, string incomingInstruction ){
            currentPosition = currentPosition + 1;
            Drink newDrink = new Drink(){
                drinkId = currentPosition,
                drinkName = incomingName,
                drinkInstructions = incomingInstruction
            };
            drinkList.Add(newDrink);
            
            }
    }
}