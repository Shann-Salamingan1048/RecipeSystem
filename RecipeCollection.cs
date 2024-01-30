using System;
using System.Collections.Generic;

namespace RecipeSystem
{
    class RecipeCollection
    {
        private List<Recipe> RecipeCollections = new List<Recipe>();
        private string RecipeCategory;
        public RecipeCollection(string category)
        {
            this.RecipeCategory = category;
        }
        public void AddRecipe(Recipe recipe)
        {
            RecipeCollections.Add(recipe);
        }
        public void RemoveRecipe(Recipe recipe)
        {
            RecipeCollections.Remove(recipe);
        }
        public void PrintAllRecipe()
        {
            if (RecipeCollections.Count > 0)
            {
                Console.WriteLine("Category: {0}", this.RecipeCategory);
                foreach (var i in RecipeCollections)
                {
                    Console.WriteLine();
                    i.PrintDetails();
                }
            }
            else
            {
                Console.WriteLine("No Available Recipes");
            }
        }
    }
}
