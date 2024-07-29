using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookBook.UI;
using DataAccessLayer.Contracts;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CookBook
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ServiceCollection services = ConfigureServices();
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            var statForm = serviceProvider.GetRequiredService<RecipesForm>();

            Application.Run(statForm);
        }

        static ServiceCollection ConfigureServices()
        {
            ServiceCollection services = new ServiceCollection();

            if (ConfigurationManager.AppSettings["repositoryType"] == "sql")
                services.AddTransient<IIngredientsRepository>(_ => new IngredientsRepository());
            else if (ConfigurationManager.AppSettings["repositoryType"] == "txt")
                services.AddTransient<IIngredientsRepository>(_ => new IngredientsTxtRepository());
            else//default value
                services.AddTransient<IIngredientsRepository>(_ => new IngredientsRepository());

            services.AddTransient<IRecipeTypesRepository>(_ => new RecipeTypesRepository());
            services.AddTransient<IRecipesRepository>(_ => new RecipesRepository());

            services.AddTransient<IngredientsForm>();
            services.AddTransient<RecipesForm>();
            services.AddTransient<RecipeTypesForm>();
            services.AddTransient<RecipeIngredientsForm>();

            return services;    
        }
    }
}
