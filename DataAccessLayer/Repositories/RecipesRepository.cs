using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using DataAccessLayer.Contracts;
using DataAccessLayer.CustomQueryResults;
using DomanModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataAccessLayer.Repositories
{
    public class RecipesRepository : IRecipesRepository
    {
        public event Action<string> OnError;
        private void ErrorOccured(string errorMessage)
        {
            if (OnError != null)
                OnError.Invoke(errorMessage);
        }
        public async Task AddRecipe(Recipe recipe)
        {
            try
            {
                string delay = "DO SLEEP(5);";
                string query = delay + " insert into Recipes(Name, Description, Image, RecipeTypeId) values(@Name, @Description, @Image, @RecipeTypeId)";

                using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipe);
                }
            }
            catch (MySqlException ex)
            {
                string errorMessage = "";
                if (ex.Number == 1062)
                    errorMessage = "That recipe already exists.";
                else
                    errorMessage = "An error happend in the database.";
                ErrorOccured(errorMessage);
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while adding ingredient.";
                ErrorOccured(errorMessage);
            }
        }
        public async Task<List<RecipeWithType>> GetRecipes()
        {
            try
            {
                string delay = "DO SLEEP(2);";
                string query = delay + @" select r.Id, r.Name, r.Description, rt.Name as 'Type', r.RecipeTypeId, r.Image
                                          from recipes as r join recipetypes as rt
                                          on r.RecipeTypeId = rt.Id";

                using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<RecipeWithType>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while getting recipes.";
                ErrorOccured(errorMessage);
                return new List<RecipeWithType>();
            }
        }
        public async Task DeleteRecipe(int Id)
        {
            try
            {
                string query = $"DELETE FROM Recipes WHERE Id = {Id}";

                using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(sql: query);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while deleting recipe.";
                ErrorOccured(errorMessage);
            }
        }
        public async Task EditRecipe(Recipe recipe)
        {
            try
            {
                string query = "UPDATE recipes SET Name = @Name, Description = @Description, RecipeTypeId = @RecipeTypeId" + (recipe.Image!=null? ", Image = @Image":"") + " WHERE Id = @Id";

                using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipe);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while edditing recipe.";
                ErrorOccured(errorMessage);
            }
        }
    }
}
