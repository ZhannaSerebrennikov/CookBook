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
using Microsoft.Extensions.DependencyInjection;
using DataAccessLayer.Repositories;
using CookBook.Helpers;
using System.IO;
using System.Reflection;
using DataAccessLayer.CustomQueryResults;

namespace CookBook.UI
{
    public partial class RecipesForm : Form
    {
        private readonly IRecipeTypesRepository _recipeTypesRepository;
        private readonly IServiceProvider _serviceProvider;
        private readonly IRecipesRepository _recipesRepository;

        private Image _placeholderImage
        {
            get
            {
                var executingAssemblyLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var imagePath = Path.Combine(executingAssemblyLocation, "Assets\\Images\\uploadImage.png");
                return Image.FromFile(imagePath);
            }
        }
        private bool _isUserImageAdded = false;
        private int _recipeToEditId;
        private List<RecipeWithType> _resipesCashe;
        public RecipesForm(IRecipeTypesRepository recipeTypesRepository, IServiceProvider serviceProvider, IRecipesRepository recipesRepository)
        {
            InitializeComponent();
            _recipeTypesRepository = recipeTypesRepository;
            _serviceProvider = serviceProvider;
            _recipesRepository = recipesRepository;
            _recipesRepository.OnError += OnErrorOccured;
        }

        private void OnErrorOccured(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        private async Task RefreshRecipeTypes()
        {
            RecipeType previouslySelectedFilter = (RecipeType)recipeFilterCbx.SelectedItem;
            RecipeType previouslySelectedRecipeType = (RecipeType)recipeTyperCbx.SelectedItem;

            List<RecipeType> recipeTypes = await _recipeTypesRepository.GetRecipeTypes();

            recipeTyperCbx.DataSource = recipeTypes;
            recipeTyperCbx.DisplayMember = "Name";

            List<RecipeType> filterList = new List<RecipeType>();
            filterList.Add(new RecipeType("All recipe types", 0));
            filterList.AddRange(recipeTypes);

            recipeFilterCbx.DataSource = filterList;
            recipeFilterCbx.DisplayMember = "Name";

            if(previouslySelectedFilter != null && previouslySelectedFilter.Id != 0)
            {
                int indexToSelecet = FindRecipeTypeIndex(previouslySelectedFilter.Id);
                recipeFilterCbx.SelectedIndex = indexToSelecet + 1;
            }

            if (previouslySelectedRecipeType != null && previouslySelectedRecipeType.Id != 0)
            {
                int indexToSelecet = FindRecipeTypeIndex(previouslySelectedRecipeType.Id);
                recipeTyperCbx.SelectedIndex = indexToSelecet;
            }
        }
        private async void RereshRecipesCache()
        {
            _resipesCashe = await _recipesRepository.GetRecipes();
            FilterGridData();
        }

        private void FilterGridData()
        {
            RecipeType selectedType = (RecipeType)recipeFilterCbx.SelectedItem;

            if (selectedType.Id == 0)
                reciipesGrid.DataSource = _resipesCashe;
            else
                reciipesGrid.DataSource = _resipesCashe.Where(r => r.RecipeTypeId == selectedType.Id).ToList();
        }

        private async void RecipesForm_Load(object sender, EventArgs e)
        {
            CustomizeGridAppearance();
            await RefreshRecipeTypes();
            RereshRecipesCache();
            recipePictureBox.Image = _placeholderImage;
            recipePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            editRecipeBtn.Visible = false;
        }

        private void addRecipeTypeBtn_Click(object sender, EventArgs e)
        {

            RecipeTypesForm form = _serviceProvider.GetRequiredService<RecipeTypesForm>();
            form.FormClosed +=(sender1, e1) => RefreshRecipeTypes();
            form.ShowDialog();
        }

        private void ClearAllFields()
        {
           // RecipeType recipeType = new RecipeType();
            nameTxt.Text = string.Empty;
            descriptionTxt.Text = string.Empty;
            recipePictureBox.ImageLocation = string.Empty;
            recipePictureBox.Image = _placeholderImage;
            _isUserImageAdded = false;
            // recipeTyperCbx.Text = string.Empty;
            //imagelbl.Text = string.Empty;
        }

        private bool IsValid()
        {
            bool isValid = true;
            string message = "";

            if (String.IsNullOrEmpty(nameTxt.Text))
            {
                isValid = false;
                message += "Please enter name.\n\n";
            }
            if (String.IsNullOrEmpty(descriptionTxt.Text))
            {
                isValid = false;
                message += "Please enter description.\n\n";
            }
            if (!isValid)
            {
                MessageBox.Show(message, "Form not valid!");
            }

            return isValid;
        }

        private async void addRecipeBtn_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;

            byte[] image = null;

            if(_isUserImageAdded == true)
            {
                image = ImageHelper.ConvertToDbImage(recipePictureBox.ImageLocation);
            }
            int recipeTypeId = ((RecipeType)recipeTyperCbx.SelectedItem).Id;
            Recipe newRecipe = new Recipe(nameTxt.Text, descriptionTxt.Text, image, recipeTypeId);

           await _recipesRepository.AddRecipe(newRecipe);

            ClearAllFields();
            RefreshRecipeTypes();
            RereshRecipesCache();
        }

        private void reciipesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void recipePictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Please select an image",
                Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jepg",
                Multiselect = false
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { 
                    recipePictureBox.ImageLocation = openFileDialog.FileName;
                    _isUserImageAdded = true;
                }                   
            }
        }

        private void clearAllFieldsBtn_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            editRecipeBtn.Visible = false;
        }
        private void CustomizeGridAppearance()
        {
            reciipesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            reciipesGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[6];
            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Description", HeaderText = "Description" };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Type", HeaderText = "Type" };
            columns[4] = new DataGridViewButtonColumn() { Text = "Edit", Name = "EditBtn", HeaderText = "", UseColumnTextForButtonValue = true };
            columns[5] = new DataGridViewButtonColumn() { Text = "Delete", Name = "DeleteBtn", HeaderText = "", UseColumnTextForButtonValue = true };

            reciipesGrid.RowHeadersVisible = false;
            reciipesGrid.Columns.Clear();
            reciipesGrid.Columns.AddRange(columns);
        }

        private async void reciipesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && reciipesGrid.CurrentCell is DataGridViewButtonCell)
            {
                RecipeWithType clickedRecipe = (RecipeWithType)reciipesGrid.Rows[e.RowIndex].DataBoundItem;

                if (reciipesGrid.CurrentCell.OwningColumn.Name == "DeleteBtn")
                {
                    await _recipesRepository.DeleteRecipe(clickedRecipe.Id);
                    RereshRecipesCache();
                }
                else if (reciipesGrid.CurrentCell.OwningColumn.Name == "EditBtn")
                {

                    FillFormForEdit(clickedRecipe);
                    editRecipeBtn.Visible = true;
                    _recipeToEditId = clickedRecipe.Id;
                }
            }
        }

        private void FillFormForEdit(RecipeWithType clickedRecipe)
        {
            nameTxt.Text= clickedRecipe.Name;
            descriptionTxt.Text = clickedRecipe.Description;
            if (clickedRecipe.Image != null)
            {
                recipePictureBox.Image = ImageHelper.ConvertFromDbImage(clickedRecipe.Image);
            }
            else
                recipePictureBox.Image = _placeholderImage;

            recipeTyperCbx.SelectedItem = FindRecipeTypeIndex(clickedRecipe.RecipeTypeId);
        }

        private int FindRecipeTypeIndex(int recipeTypeId)
        {
            List<RecipeType> allRecipeTypes = (List<RecipeType>)recipeTyperCbx.DataSource;
            RecipeType matchingRecipeType = null;

            foreach(RecipeType rt in allRecipeTypes)
            {
                if(rt.Id == recipeTypeId)
                {
                    matchingRecipeType = rt;
                }
            }
            int index = recipeTyperCbx.Items.IndexOf(matchingRecipeType);
            return index;
        }

        private async void editRecipeBtn_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;

            byte[] image = null;

            if (_isUserImageAdded == true)
            {
                image = ImageHelper.ConvertToDbImage(recipePictureBox.ImageLocation);
            }
            int recipeTypeId = ((RecipeType)recipeTyperCbx.SelectedItem).Id;
            Recipe newRecipe = new Recipe(nameTxt.Text, descriptionTxt.Text, image, recipeTypeId, _recipeToEditId);

            await _recipesRepository.EditRecipe(newRecipe);

            ClearAllFields();
            RereshRecipesCache();
            editRecipeBtn.Visible = false;
        }

        private void recipeFilterCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGridData();
        }

        private void recipeIngredientsBtn_Click(object sender, EventArgs e)
        {
            RecipeIngredientsForm form = _serviceProvider.GetRequiredService<RecipeIngredientsForm>();
            form.ShowDialog();
        }
    }
 }
