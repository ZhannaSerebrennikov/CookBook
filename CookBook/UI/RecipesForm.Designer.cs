
namespace CookBook.UI
{
    partial class RecipesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.descriptionlbl = new System.Windows.Forms.Label();
            this.imagelbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.recipeTyperCbx = new System.Windows.Forms.ComboBox();
            this.addRecipeTypeBtn = new System.Windows.Forms.Button();
            this.descriptionTxt = new System.Windows.Forms.RichTextBox();
            this.recipePictureBox = new System.Windows.Forms.PictureBox();
            this.addRecipeBtn = new System.Windows.Forms.Button();
            this.recipeIngredientsBtn = new System.Windows.Forms.Button();
            this.clearAllFieldsBtn = new System.Windows.Forms.Button();
            this.recipeFilterCbx = new System.Windows.Forms.ComboBox();
            this.reciipesGrid = new System.Windows.Forms.DataGridView();
            this.editRecipeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recipePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciipesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(710, 45);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(112, 37);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name:";
            this.nameLbl.UseMnemonic = false;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(710, 115);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(96, 37);
            this.typeLbl.TabIndex = 1;
            this.typeLbl.Text = "Type:";
            // 
            // descriptionlbl
            // 
            this.descriptionlbl.AutoSize = true;
            this.descriptionlbl.Location = new System.Drawing.Point(710, 217);
            this.descriptionlbl.Name = "descriptionlbl";
            this.descriptionlbl.Size = new System.Drawing.Size(186, 37);
            this.descriptionlbl.TabIndex = 2;
            this.descriptionlbl.Text = "Description:";
            // 
            // imagelbl
            // 
            this.imagelbl.AutoSize = true;
            this.imagelbl.Location = new System.Drawing.Point(710, 371);
            this.imagelbl.Name = "imagelbl";
            this.imagelbl.Size = new System.Drawing.Size(114, 37);
            this.imagelbl.TabIndex = 3;
            this.imagelbl.Text = "Image:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(891, 38);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(297, 44);
            this.nameTxt.TabIndex = 4;
            // 
            // recipeTyperCbx
            // 
            this.recipeTyperCbx.FormattingEnabled = true;
            this.recipeTyperCbx.Location = new System.Drawing.Point(891, 107);
            this.recipeTyperCbx.Name = "recipeTyperCbx";
            this.recipeTyperCbx.Size = new System.Drawing.Size(186, 45);
            this.recipeTyperCbx.TabIndex = 5;
            // 
            // addRecipeTypeBtn
            // 
            this.addRecipeTypeBtn.Location = new System.Drawing.Point(1094, 106);
            this.addRecipeTypeBtn.Name = "addRecipeTypeBtn";
            this.addRecipeTypeBtn.Size = new System.Drawing.Size(94, 45);
            this.addRecipeTypeBtn.TabIndex = 6;
            this.addRecipeTypeBtn.Text = "Add";
            this.addRecipeTypeBtn.UseVisualStyleBackColor = true;
            this.addRecipeTypeBtn.Click += new System.EventHandler(this.addRecipeTypeBtn_Click);
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(891, 180);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(297, 104);
            this.descriptionTxt.TabIndex = 7;
            this.descriptionTxt.Text = "";
            // 
            // recipePictureBox
            // 
            this.recipePictureBox.Location = new System.Drawing.Point(891, 310);
            this.recipePictureBox.Name = "recipePictureBox";
            this.recipePictureBox.Size = new System.Drawing.Size(297, 148);
            this.recipePictureBox.TabIndex = 8;
            this.recipePictureBox.TabStop = false;
            this.recipePictureBox.Click += new System.EventHandler(this.recipePictureBox_Click);
            // 
            // addRecipeBtn
            // 
            this.addRecipeBtn.Location = new System.Drawing.Point(891, 491);
            this.addRecipeBtn.Name = "addRecipeBtn";
            this.addRecipeBtn.Size = new System.Drawing.Size(297, 42);
            this.addRecipeBtn.TabIndex = 9;
            this.addRecipeBtn.Text = "Add Recipe";
            this.addRecipeBtn.UseVisualStyleBackColor = true;
            this.addRecipeBtn.Click += new System.EventHandler(this.addRecipeBtn_Click);
            // 
            // recipeIngredientsBtn
            // 
            this.recipeIngredientsBtn.Location = new System.Drawing.Point(891, 539);
            this.recipeIngredientsBtn.Name = "recipeIngredientsBtn";
            this.recipeIngredientsBtn.Size = new System.Drawing.Size(297, 42);
            this.recipeIngredientsBtn.TabIndex = 10;
            this.recipeIngredientsBtn.Text = "Recipe Ingredients ";
            this.recipeIngredientsBtn.UseVisualStyleBackColor = true;
            this.recipeIngredientsBtn.Click += new System.EventHandler(this.recipeIngredientsBtn_Click);
            // 
            // clearAllFieldsBtn
            // 
            this.clearAllFieldsBtn.Location = new System.Drawing.Point(891, 587);
            this.clearAllFieldsBtn.Name = "clearAllFieldsBtn";
            this.clearAllFieldsBtn.Size = new System.Drawing.Size(297, 42);
            this.clearAllFieldsBtn.TabIndex = 11;
            this.clearAllFieldsBtn.Text = "Clear all fields";
            this.clearAllFieldsBtn.UseVisualStyleBackColor = true;
            this.clearAllFieldsBtn.Click += new System.EventHandler(this.clearAllFieldsBtn_Click);
            // 
            // recipeFilterCbx
            // 
            this.recipeFilterCbx.FormattingEnabled = true;
            this.recipeFilterCbx.Location = new System.Drawing.Point(12, 37);
            this.recipeFilterCbx.Name = "recipeFilterCbx";
            this.recipeFilterCbx.Size = new System.Drawing.Size(675, 45);
            this.recipeFilterCbx.TabIndex = 12;
            this.recipeFilterCbx.SelectedIndexChanged += new System.EventHandler(this.recipeFilterCbx_SelectedIndexChanged);
            // 
            // reciipesGrid
            // 
            this.reciipesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reciipesGrid.Location = new System.Drawing.Point(13, 107);
            this.reciipesGrid.Name = "reciipesGrid";
            this.reciipesGrid.RowHeadersWidth = 62;
            this.reciipesGrid.RowTemplate.Height = 28;
            this.reciipesGrid.Size = new System.Drawing.Size(674, 522);
            this.reciipesGrid.TabIndex = 13;
            this.reciipesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reciipesGrid_CellClick);
            this.reciipesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reciipesGrid_CellContentClick);
            // 
            // editRecipeBtn
            // 
            this.editRecipeBtn.Location = new System.Drawing.Point(891, 491);
            this.editRecipeBtn.Name = "editRecipeBtn";
            this.editRecipeBtn.Size = new System.Drawing.Size(297, 42);
            this.editRecipeBtn.TabIndex = 14;
            this.editRecipeBtn.Text = "Edit recipe";
            this.editRecipeBtn.UseVisualStyleBackColor = true;
            this.editRecipeBtn.Click += new System.EventHandler(this.editRecipeBtn_Click);
            // 
            // RecipesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 636);
            this.Controls.Add(this.editRecipeBtn);
            this.Controls.Add(this.reciipesGrid);
            this.Controls.Add(this.recipeFilterCbx);
            this.Controls.Add(this.clearAllFieldsBtn);
            this.Controls.Add(this.recipeIngredientsBtn);
            this.Controls.Add(this.addRecipeBtn);
            this.Controls.Add(this.recipePictureBox);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.addRecipeTypeBtn);
            this.Controls.Add(this.recipeTyperCbx);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.imagelbl);
            this.Controls.Add(this.descriptionlbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.nameLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RecipesForm";
            this.Text = "RecipesForm";
            this.Load += new System.EventHandler(this.RecipesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciipesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label descriptionlbl;
        private System.Windows.Forms.Label imagelbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.ComboBox recipeTyperCbx;
        private System.Windows.Forms.Button addRecipeTypeBtn;
        private System.Windows.Forms.RichTextBox descriptionTxt;
        private System.Windows.Forms.PictureBox recipePictureBox;
        private System.Windows.Forms.Button addRecipeBtn;
        private System.Windows.Forms.Button recipeIngredientsBtn;
        private System.Windows.Forms.Button clearAllFieldsBtn;
        private System.Windows.Forms.ComboBox recipeFilterCbx;
        private System.Windows.Forms.DataGridView reciipesGrid;
        private System.Windows.Forms.Button editRecipeBtn;
    }
}