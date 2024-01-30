using System;
namespace RecipeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating recipe instances
            Recipe reci = new Recipe("Spaghetti");
            reci.AddIngredient(new Ingredient("Stick Spag", 1, "Cup"));
            reci.AddIngredient(new Ingredient("Tomato Sauce", 2, "Cups"));
            reci.AddIngredient(new Ingredient("Hot dog", 0.5, "Kg"));

            Recipe reci2 = new Recipe("Macaroni");
            reci2.AddIngredient(new Ingredient("Macaroni Sticks", 0.5, "Kg"));
            reci2.AddIngredient(new Ingredient("All-purpose cream", 2, "Pieces"));
            reci2.AddIngredient(new Ingredient("Condensed Milk", 2, "Pieces"));

            // Creating a recipe collection
            RecipeCollection rc = new RecipeCollection("Pasta");
            rc.AddRecipe(reci);
            rc.AddRecipe(reci2);
            
            // Printing all recipes in the collection
            rc.PrintAllRecipe();
            // Remove
            Console.WriteLine();
            rc.RemoveRecipe(reci);
            rc.PrintAllRecipe();
            Console.ReadKey();
        }
    }
}
