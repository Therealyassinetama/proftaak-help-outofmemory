using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Hope_Final_version
{
    internal class Recipe
    {
        public List<Ingredient> ingredients = new List<Ingredient>();

        private string name;
        private int calories;
        private int price;

        public Recipe(string naam)
        {
            Naam = naam; for (int i = 0; i < 1; i++)
            {
                Ingredient i1 = new Ingredient(name + i.ToString());
                ingredients.Add(i1);
            }
        }

        public string Naam { get; set; }
        public int Calories { get; set; }
        public int Price { get; set; }


        public override string ToString()
        {
            return name;
        }
    }
}
