﻿namespace Actividad_recetas
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            bool menu = true;
            List<Recipe> recipesList = new List<Recipe>();
            while (menu)
            {
                Console.Clear();
                ShowMenu();
                option= Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.Clear ();
                            Recipe.AddRecipes(recipesList);
                            Console.ReadKey();
                            break;
                        }
                }
                
            }
        }
        public static void ShowMenu()
        {
            Console.WriteLine("1. Agregar receta.");
        }
    }
}