using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net.Http;
using InternetData.Properties;
using static InternetData.Properties.Recipes;

namespace InternetData
{
    public class MainClass
    {
        public static void GetRecipesFromSearch()
        {
            HttpClient client = new HttpClient();

            Console.Write("What meal do you want to search for? ");
            string meal = Console.ReadLine();

            try
            {
                RecipeInfo recipe = Recipes.getRecipeInfo(meal);

                Console.WriteLine(recipe.strMeal);
                Console.WriteLine("Meal ID: " + recipe.idMeal);
                Console.WriteLine("Meal category: " + recipe.strCategory);
                Console.WriteLine("Meal cuisine: " + recipe.strArea);
                if (string.IsNullOrEmpty(recipe.strSource) == false)
                    Console.WriteLine("Original link: " + recipe.strSource);
                Console.WriteLine("");
                Console.WriteLine("Ingredients:");

                if (string.IsNullOrEmpty(recipe.strMeasure1) == false)
                    Console.WriteLine(recipe.strMeasure1 + " " + recipe.strIngredient1);

                if (string.IsNullOrEmpty(recipe.strMeasure2) == false)
                    Console.WriteLine(recipe.strMeasure2 + " " + recipe.strIngredient2);

                if (string.IsNullOrEmpty(recipe.strMeasure3) == false)
                    Console.WriteLine(recipe.strMeasure3 + " " + recipe.strIngredient3);

                if (string.IsNullOrEmpty(recipe.strMeasure4) == false)
                    Console.WriteLine(recipe.strMeasure4 + " " + recipe.strIngredient4);

                if (string.IsNullOrEmpty(recipe.strMeasure5) == false)
                    Console.WriteLine(recipe.strMeasure5 + " " + recipe.strIngredient5);

                if (string.IsNullOrEmpty(recipe.strMeasure6) == false)
                    Console.WriteLine(recipe.strMeasure6 + " " + recipe.strIngredient6);

                if (string.IsNullOrEmpty(recipe.strMeasure7) == false)
                    Console.WriteLine(recipe.strMeasure7 + " " + recipe.strIngredient7);

                if (string.IsNullOrEmpty(recipe.strMeasure8) == false)
                    Console.WriteLine(recipe.strMeasure8 + " " + recipe.strIngredient8);

                if (string.IsNullOrEmpty(recipe.strMeasure9) == false)
                    Console.WriteLine(recipe.strMeasure9 + " " + recipe.strIngredient9);

                if (string.IsNullOrEmpty(recipe.strMeasure10) == false)
                    Console.WriteLine(recipe.strMeasure10 + " " + recipe.strIngredient10);

                if (string.IsNullOrEmpty(recipe.strMeasure11) == false)
                    Console.WriteLine(recipe.strMeasure11 + " " + recipe.strIngredient11);

                if (string.IsNullOrEmpty(recipe.strMeasure12) == false)
                    Console.WriteLine(recipe.strMeasure12 + " " + recipe.strIngredient12);

                if (string.IsNullOrEmpty(recipe.strMeasure13) == false)
                    Console.WriteLine(recipe.strMeasure13 + " " + recipe.strIngredient13);

                if (string.IsNullOrEmpty(recipe.strMeasure14) == false)
                    Console.WriteLine(recipe.strMeasure14 + " " + recipe.strIngredient14);

                if (string.IsNullOrEmpty(recipe.strMeasure15) == false)
                    Console.WriteLine(recipe.strMeasure15 + " " + recipe.strIngredient15);

                if (string.IsNullOrEmpty(recipe.strMeasure16) == false)
                    Console.WriteLine(recipe.strMeasure16 + " " + recipe.strIngredient16);

                if (string.IsNullOrEmpty(recipe.strMeasure17) == false)
                    Console.WriteLine(recipe.strMeasure17 + " " + recipe.strIngredient17);

                if (string.IsNullOrEmpty(recipe.strMeasure18) == false)
                    Console.WriteLine(recipe.strMeasure18 + " " + recipe.strIngredient18);

                if (string.IsNullOrEmpty(recipe.strMeasure19) == false)
                    Console.WriteLine(recipe.strMeasure19 + " " + recipe.strIngredient19);

                if (string.IsNullOrEmpty(recipe.strMeasure20) == false)
                    Console.WriteLine(recipe.strMeasure20 + " " + recipe.strIngredient20);

                Console.WriteLine("");

                Console.WriteLine("Instructions:");
                Console.WriteLine(recipe.strInstructions);
            }

            catch (NullReferenceException)
            {
                Console.WriteLine("No result found.");
            }

            Console.ReadLine();
        }

        public static void Main (string[] args)
        {
            GetRecipesFromSearch();
        }
    }
}
