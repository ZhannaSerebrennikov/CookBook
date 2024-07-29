using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Contracts;
using DomanModel.Models;

namespace CookBook.UI
{
    public partial class RecipeTypesForm : Form
    {
        private readonly IRecipeTypesRepository _recipeTypesRepository;
        public RecipeTypesForm(IRecipeTypesRepository recipeTypesRepository)
        {
            InitializeComponent();
            _recipeTypesRepository = recipeTypesRepository;
            _recipeTypesRepository.OnError += (message) => MessageBox.Show(message);
        }
            
        private async void RefreshRecipeTypesList()
        {
            recipeTypesLbx.DataSource = await _recipeTypesRepository.GetRecipeTypes();
            recipeTypesLbx.DisplayMember = "Name";
        }

        private void RecipeTypesForm_Load(object sender, EventArgs e)
        {
            RefreshRecipeTypesList();
        }

        private async void addRecipeTypeBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(newTypeTxt.Text))
            {
                return;
            }

            RecipeType newRecipeType = new RecipeType(newTypeTxt.Text);

            await _recipeTypesRepository.AddRecipeType(newRecipeType);

            RefreshRecipeTypesList();
            newTypeTxt.Text = "";
        }
    }
}
