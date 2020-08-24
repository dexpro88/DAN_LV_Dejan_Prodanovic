using DAN_LV_Dejan_Prodanovic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAN_LV_Dejan_Prodanovic.DataAcces
{
    class IngredientData
    {
       
        public List<Ingredient> Ingredients { get; set; }

        public IngredientData()
        {
            Ingredients = new List<Ingredient>();

            Ingredient ingredient = new Ingredient()
            {
                Name = "Salama",
                Price = 10
            };

            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "Sunka",
                Price = 12
            };
            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "Majonez",
                Price = 15
            };
            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "Kulen",
                Price = 9
            };
            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "Kecap",
                Price = 10
            };
            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "Ljuta paprika",
                Price = 14
            };
            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "Masline",
                Price = 16
            };
            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "Origano",
                Price = 9
            };
            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "Susam",
                Price = 8
            };
            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "Sir",
                Price = 17
            };
            Ingredients.Add(ingredient);
        }

        public Ingredient GetIngredientByName(string name)
        {
            return Ingredients.Where(x => x.Name.Equals(name)).FirstOrDefault();
        }
    }
}
