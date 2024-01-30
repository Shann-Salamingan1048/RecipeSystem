using System;
using System.Collections.Generic;

namespace RecipeSystem
{
    class Recipe 
    {
        private List<Ingredient> Ingredients = new List<Ingredient>();
        private string Name;
        public Recipe(string Name) 
        {
            this.Name = Name;
        }
 
        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }
        public void PrintDetails()
        {
            Console.WriteLine("Recipe Name: {0}", this.Name);
            if (Ingredients.Count > 0)
            {
                Console.WriteLine("Ingredients: ");
                foreach (var i in Ingredients)
                {
                    Console.WriteLine("{0} {1} {2}".PadLeft(15), i.Name, i.Quantity, i.UnitMeasurement);
                }
            }
            else
            {
                Console.WriteLine("No Ingredients!");
                Console.WriteLine();
            }
        }
    }
}
