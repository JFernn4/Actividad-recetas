using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
