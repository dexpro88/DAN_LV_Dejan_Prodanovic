using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAN_LV_Dejan_Prodanovic.Model
{
    class Pizza
    {
        public string Size { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Pizza()
        {
            Ingredients = new List<Ingredient>();
        }
    }
}
