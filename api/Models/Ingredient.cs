using System;
using System.Collections.Generic;

namespace drinkfinder.Models{

    public class Ingredient
    {
        

        public List<Ingredient> ingredientList { get; set; }
        
        

        public int currentPosition = 0;
        
        public int ingredientId { get; set; }
        public string ingredientName { get; set; }

        public void addIngredient(string incomingName){
            currentPosition = currentPosition + 1;
            Ingredient newIngredient = new Ingredient(){
                ingredientId = currentPosition,
                ingredientName = incomingName
            };
            ingredientList.Add(newIngredient);
            
            }
        }

    }
