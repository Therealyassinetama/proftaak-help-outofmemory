using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Hope_Final_version
{
    class Ingredient
    {
        private string Name;
        private int Ammount;

        public Ingredient(string naam)
        {
            name = naam;
        }

        public string name { get; set; }
        public int amount { get; set; }


        public override string ToString()
        {
            return name;
        }
    }
}
