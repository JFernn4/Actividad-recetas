using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_recetas
{
    internal class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Description { get; set; }

        public Recipe(int id, string name, string ingredients, string description)
        {
            Id = id;
            Name = name;
            Ingredients = ingredients;
            Description = description;
        }
        public static void AddRecipes (List<Recipe> recipesList)
        {
            Console.WriteLine("Ingresa el número de receta.");
            int id= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el nombre de la receta.");
            string name = Console.ReadLine();
            Console.WriteLine("Ingresa los ingredientes.");
            string ingredients = Console.ReadLine();
            Console.WriteLine("Ingresa la descripción o pasos de la receta.");
            string description = Console.ReadLine();
            Recipe recipe= new Recipe(id, name, ingredients, description);
            recipesList.Add(recipe);
            Console.WriteLine("La receta se ha registrado.");
        }
    }
}
