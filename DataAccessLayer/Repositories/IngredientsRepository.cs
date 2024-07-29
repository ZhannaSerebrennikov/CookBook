using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
    public class IngredientsRepository: IIngredientsRepository
    {
        public event Action<string> OnError;
        public async Task AddIngredient(Ingredient ingredient)
        {
            try
            {
                string delay = "DO SLEEP(5);";
                string query = delay + " insert into Ingredients(Name, Weight, KcalPer100g,PricePer100g, Type) values(@Name, @Weight, @KcalPer100g,@PricePer100g, @Type)";

                 using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                 {
                     await connection.ExecuteAsync(query, ingredient);
                 }
            }
            catch(SqlException ex)
            {
                string errorMessage = "";
                if (ex.Number == 2627)
                    errorMessage = "That ingredient already exists.";
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
        private void ErrorOccured(string errorMessage)
        {
            if (OnError != null)
                OnError.Invoke(errorMessage);
        }
        public async Task<List<Ingredient>> GetIngredients(string name = "")
        {
            try
            {
                string delay = "DO SLEEP(2);";
                string query = delay + " select * from Ingredients";

                if (!string.IsNullOrEmpty(name))
                    query+=$" where Name like '{name}%'";

                using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<Ingredient>(query)).ToList();  
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while getting ingredient.";
                ErrorOccured(errorMessage);
                return new List<Ingredient>();
            }
        }
        public async Task DeleteIngredient(Ingredient ingredient)
        {
            try
            {
                string query = $"DELETE FROM ingredients WHERE Id = {ingredient.Id}";

                using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(sql:query);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while deleting ingredient.";
                ErrorOccured(errorMessage);
            }
        }
        public async Task EditIngredient(Ingredient ingredient)
        {
            try
            {
                string query = "UPDATE ingredients SET Name = @Name, Weight = @Weight, KcalPer100g = @KcalPer100g, PricePer100g = @PricePer100g, Type = @Type WHERE Id = @Id";

                using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, ingredient);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while edditing ingredient.";
                ErrorOccured(errorMessage);
            }
        }
    }
}
