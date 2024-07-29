using Dapper;
using DataAccessLayer.Contracts;
using DataAccessLayer.CustomQueryResults;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RecipeIngredientsRepository: IRecipeIngredientsRepository
    {
        public event Action<string> OnError;
        private void ErrorOccured(string errorMessage)
        {
            if (OnError != null)
                OnError.Invoke(errorMessage);
        }
        public async Task<List<RecipeIngredientWithNameAndAmount>> GetRecipeIngredients(int recipeId)
        {
            try
            {
                string delay = "DO SLEEP(2);";
                string query = delay + $@" Select i.Name, ri.IngredientId, ri.Amount
                                        from ingredients as i join recipeingredients as ri
                                        on i.Id = ri.IngredientId
                                        where ri.RecipeId={recipeId}";

                using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<RecipeIngredientWithNameAndAmount>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while getting recipe ingredients.";
                ErrorOccured(errorMessage);
                return new List<RecipeIngredientWithNameAndAmount>();
            }
        }
    }
}
