using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomanModel.Models;

namespace DataAccessLayer.Contracts
{
    public interface IRecipeTypesRepository
    {
        event Action<string> OnError;
        Task AddRecipeType(RecipeType recipeType);
        Task<List<RecipeType>> GetRecipeTypes();
    }
}
