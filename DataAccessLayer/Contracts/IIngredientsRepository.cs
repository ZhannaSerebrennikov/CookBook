using DomanModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contracts
{
    public interface IIngredientsRepository
    {
       event Action<string> OnError;
       Task AddIngredient(Ingredient ingredient);

       Task<List<Ingredient>> GetIngredients(string name = "");

       Task DeleteIngredient(Ingredient ingredient);

        Task EditIngredient(Ingredient ingredient);
    }
}
