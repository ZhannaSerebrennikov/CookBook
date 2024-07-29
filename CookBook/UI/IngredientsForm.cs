using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomanModel.Models;
using DataAccessLayer.Repositories;
using DataAccessLayer.Contracts;

namespace CookBook.UI
{
    public partial class IngredientsForm : Form
    {
        readonly IIngredientsRepository _ingredientsRepository;
        private int _ingredientToEdtId;
        public IngredientsForm(IIngredientsRepository ingredientsRepository)
        {
            InitializeComponent();
            _ingredientsRepository = ingredientsRepository;
            _ingredientsRepository.OnError += OnErrorOccured;
        }

        private void OnErrorOccured(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        private async void AddToFridgeBtn_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;
            Ingredient ingredient = new Ingredient(NameTxt.Text, TypeTxt.Text, KcalPer100gNum.Value, PricePer100gNum.Value, WeightNum.Value);

            AddToFridgeBtn.Enabled = false;
            await _ingredientsRepository.AddIngredient(ingredient);
            AddToFridgeBtn.Enabled = true;
            ClearAllFields();
            RefreshrGidData();
        }

        private void ClearAllFields()
        {
            NameTxt.Text = string.Empty;
            TypeTxt.Text = string.Empty;
            WeightNum.Value = 1;
            KcalPer100gNum.Value = 0;
            PricePer100gNum.Value = 0;
            searchTxt.Text = string.Empty;
        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            RefreshrGidData();
            CustomizeGridAppearance();


            AddToFridgeBtn.Visible = true;
            editBtn.Visible = false;
        }

        private async void RefreshrGidData()
        {      
            ingredientsGrid.DataSource = await _ingredientsRepository.GetIngredients(searchTxt.Text);
        }

        private void CustomizeGridAppearance()
        {
            ingredientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ingredientsGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[8];
            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Type", HeaderText = "Type" };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Weight", HeaderText = "Weight" };
            columns[4] = new DataGridViewTextBoxColumn() { DataPropertyName = "PricePer100g", HeaderText = "Price(100g)" };
            columns[5] = new DataGridViewTextBoxColumn() { DataPropertyName = "KcalPer100g", HeaderText = "Kcal(100g)"};
            columns[6] = new DataGridViewButtonColumn() { Text = "Delete", Name = "DeleteBtn", HeaderText = "", UseColumnTextForButtonValue = true };
            columns[7] = new DataGridViewButtonColumn() { Text = "Edit", Name = "EditBtn", HeaderText = "", UseColumnTextForButtonValue = true };

            ingredientsGrid.Columns.Clear();
            ingredientsGrid.Columns.AddRange(columns);
        }
        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            AddToFridgeBtn.Visible = true;
            editBtn.Visible = false;
            _ingredientToEdtId = 0;
        }

        private async void searchTxt_TextChanged(object sender, EventArgs e)
        {
            int lengthBeforePause = searchTxt.Text.Length;

            await Task.Delay(500);

            int lengthAfterPause = searchTxt.Text.Length;

            if(lengthBeforePause== lengthAfterPause)
            {
                RefreshrGidData();
            }
        }

        private void PricePer100gNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool IsValid()
        {
            bool isValid = true;
            string message = "";

            if (String.IsNullOrEmpty(NameTxt.Text))
            {
                isValid = false;
                message += "Please enter name.\n\n";
            }
            if (String.IsNullOrEmpty(TypeTxt.Text))
            {
                isValid = false;
                message += "Please enter type.\n\n";
            }
            if (WeightNum.Value <= 0)
            {
                isValid = false;
                message += "Weight must be greater than 0.\n\n";
            }
            if (KcalPer100gNum.Value < 0)
            {
                isValid = false;
                message += "Kcal must be greater than or equal to 0.\n\n";
            }
            if (PricePer100gNum.Value <= 0)
            {
                isValid = false;
                message += "Price must be greater than to 0.\n\n";
            }

            if (!isValid)
            {
                MessageBox.Show(message, "Form not valid!");
            }

            return isValid;
        }

        private async void ingredientsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && ingredientsGrid.CurrentCell is DataGridViewButtonCell)
            {
                Ingredient clickedIngredient = (Ingredient)ingredientsGrid.Rows[e.RowIndex].DataBoundItem;

                if (ingredientsGrid.CurrentCell.OwningColumn.Name == "DeleteBtn")
                {
                    await _ingredientsRepository.DeleteIngredient(clickedIngredient);
                    RefreshrGidData();
                }
                else if(ingredientsGrid.CurrentCell.OwningColumn.Name == "EditBtn")
                {

                    FillFormForEdit(clickedIngredient);
                }               
            }
        }

        private void FillFormForEdit(Ingredient clickedIngredient)
        {
            _ingredientToEdtId = clickedIngredient.Id;

            NameTxt.Text = clickedIngredient.Name;
            TypeTxt.Text = clickedIngredient.Type;
            WeightNum.Value = clickedIngredient.Weight;
            KcalPer100gNum.Value = clickedIngredient.KcalPer100g;
            PricePer100gNum.Value = clickedIngredient.PricePer100g;
            searchTxt.Text = string.Empty;

            AddToFridgeBtn.Visible = false;
            editBtn.Visible = true;
        }

        private async void editBtn_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;
            Ingredient ingredient = new Ingredient(NameTxt.Text, TypeTxt.Text, KcalPer100gNum.Value, PricePer100gNum.Value, WeightNum.Value, _ingredientToEdtId);

            editBtn.Enabled = false;
            await _ingredientsRepository.EditIngredient(ingredient);

            AddToFridgeBtn.Visible = true;
            editBtn.Visible = false;

            ClearAllFields();
            RefreshrGidData();

            _ingredientToEdtId = 0;
        }
    }
}

