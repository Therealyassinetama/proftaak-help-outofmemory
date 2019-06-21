using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Hope_Final_version
{
    internal class Order
    {
        public List<Recipe> Recipes = new List<Recipe>();

        public Order(string naam)
        {
            Name = Name;
            for(int i = 0; i<1;i++)
            {
                Recipe r1 = new Recipe(Name + i.ToString());
                Recipes.Add(r1);

            }
        }

        public string Name { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
