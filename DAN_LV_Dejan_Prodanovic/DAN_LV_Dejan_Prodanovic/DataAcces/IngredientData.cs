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
                Name = "Salami",
                Price = 10
            };

            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "Ham",
                Price = 12
            };
            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "Mayo",
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
                Name = "Ketchup",
                Price = 10
            };
            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "ChilliPaper",
                Price = 14
            };
            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "Olives",
                Price = 16
            };
            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "Oregano",
                Price = 9
            };
            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "Sesame",
                Price = 8
            };
            Ingredients.Add(ingredient);

            ingredient = new Ingredient()
            {
                Name = "Cheese",
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
