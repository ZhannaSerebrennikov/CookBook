using DataAccessLayer.CustomQueryResults;
using DomanModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contracts
{
    public interface IRecipesRepository
    {
        event Action<string> OnError;
        Task AddRecipe(Recipe recipe);
        Task<List<RecipeWithType>> GetRecipes();
        Task DeleteRecipe(int Id);
        Task EditRecipe(Recipe recipe);
    }
}
