using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Contracts;
using DomanModel.Models;

namespace DataAccessLayer.Repositories
{
    public class IngredientsTxtRepository : IIngredientsRepository
    {
        string _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "IngredientsStorage.txt");

        public event Action<string> OnError;
        public async Task AddIngredient(Ingredient ingredient)
        {
            int id = Math.Abs(Guid.NewGuid().GetHashCode());

            using(StreamWriter sw = File.AppendText(_filePath))
            {
               await sw.WriteLineAsync($"{id}|{ingredient.Name}|{ingredient.Type}|{ingredient.KcalPer100g}|{ingredient.PricePer100g}|{ingredient.Weight}");
            }
        }

        public async Task<List<Ingredient>> GetIngredients(string name = "")
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            using (StreamReader sr = File.OpenText(_filePath))
            {
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split('|');

                    Ingredient ingredient = new Ingredient();
                    ingredient.Id = int.Parse(values[0]);
                    ingredient.Name = values[1];
                    ingredient.Type = values[2];
                    ingredient.KcalPer100g = decimal.Parse(values[3]);
                    ingredient.PricePer100g = decimal.Parse(values[4]);
                    ingredient.Weight = decimal.Parse(values[5]);

                    if(string.IsNullOrEmpty(name))
                        ingredients.Add(ingredient);
                    else if(!string.IsNullOrEmpty(name) && ingredient.Name.ToLower().StartsWith(name.ToLower()))
                        ingredients.Add(ingredient);

                }
            }
            return ingredients;
        }
        public async Task DeleteIngredient(Ingredient ingredient)
        {
            int id = Math.Abs(Guid.NewGuid().GetHashCode());

            using (StreamWriter sw = File.AppendText(_filePath))
            {
                await sw.WriteLineAsync($"{id}|{ingredient.Name}|{ingredient.Type}|{ingredient.KcalPer100g}|{ingredient.PricePer100g}|{ingredient.Weight}");
            }
        }

        public async Task EditIngredient(Ingredient ingredient)
        {
            int id = Math.Abs(Guid.NewGuid().GetHashCode());

            using (StreamWriter sw = File.AppendText(_filePath))
            {
                await sw.WriteLineAsync($"{id}|{ingredient.Name}|{ingredient.Type}|{ingredient.KcalPer100g}|{ingredient.PricePer100g}|{ingredient.Weight}");
            }
        }
    }
}
