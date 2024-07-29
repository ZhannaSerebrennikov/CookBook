using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccessLayer.Contracts;
using DomanModel.Models;
using MySql.Data.MySqlClient;


namespace DataAccessLayer.Repositories
{
    public class RecipeTypesRepository : IRecipeTypesRepository
    {
        private void ErrorOccured(string errorMessage)
        {
            if (OnError != null)
                OnError.Invoke(errorMessage);
        }
        public event Action<string> OnError;
        public async Task AddRecipeType(RecipeType recipeType)
        {
            try
            {
                string delay = "DO SLEEP(5);";
                string query = delay + " insert into RecipeTypes(Name) values(@Name)";

                using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipeType);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while adding recipe type.";
                ErrorOccured(errorMessage);
            }
        }
        public async Task<List<RecipeType>> GetRecipeTypes()
        {
            try
            {
                string delay = "DO SLEEP(2);";
                string query = delay + " select * from RecipeTypes";

                using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<RecipeType>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while getting recipe types.";
                ErrorOccured(errorMessage);
                return new List<RecipeType>();
            }
        }
    }
}
