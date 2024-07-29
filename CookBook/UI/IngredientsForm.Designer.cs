
namespace CookBook.UI
{
    partial class IngredientsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.TypeTxt = new System.Windows.Forms.TextBox();
            this.WeightNum = new System.Windows.Forms.NumericUpDown();
            this.KcalPer100gNum = new System.Windows.Forms.NumericUpDown();
            this.PricePer100gNum = new System.Windows.Forms.NumericUpDown();
            this.AddToFridgeBtn = new System.Windows.Forms.Button();
            this.ingredientsGrid = new System.Windows.Forms.DataGridView();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KcalPer100gNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PricePer100gNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight (g)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kcal (100g)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price (100g)";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(823, 60);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(299, 44);
            this.NameTxt.TabIndex = 5;
            // 
            // TypeTxt
            // 
            this.TypeTxt.Location = new System.Drawing.Point(823, 121);
            this.TypeTxt.Name = "TypeTxt";
            this.TypeTxt.Size = new System.Drawing.Size(299, 44);
            this.TypeTxt.TabIndex = 6;
            // 
            // WeightNum
            // 
            this.WeightNum.DecimalPlaces = 2;
            this.WeightNum.Location = new System.Drawing.Point(823, 182);
            this.WeightNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.WeightNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WeightNum.Name = "WeightNum";
            this.WeightNum.Size = new System.Drawing.Size(299, 44);
            this.WeightNum.TabIndex = 7;
            this.WeightNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // KcalPer100gNum
            // 
            this.KcalPer100gNum.DecimalPlaces = 2;
            this.KcalPer100gNum.Location = new System.Drawing.Point(823, 244);
            this.KcalPer100gNum.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.KcalPer100gNum.Name = "KcalPer100gNum";
            this.KcalPer100gNum.Size = new System.Drawing.Size(299, 44);
            this.KcalPer100gNum.TabIndex = 8;
            // 
            // PricePer100gNum
            // 
            this.PricePer100gNum.DecimalPlaces = 2;
            this.PricePer100gNum.Location = new System.Drawing.Point(823, 307);
            this.PricePer100gNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.PricePer100gNum.Name = "PricePer100gNum";
            this.PricePer100gNum.Size = new System.Drawing.Size(299, 44);
            this.PricePer100gNum.TabIndex = 9;
            this.PricePer100gNum.ValueChanged += new System.EventHandler(this.PricePer100gNum_ValueChanged);
            // 
            // AddToFridgeBtn
            // 
            this.AddToFridgeBtn.Location = new System.Drawing.Point(627, 397);
            this.AddToFridgeBtn.Name = "AddToFridgeBtn";
            this.AddToFridgeBtn.Size = new System.Drawing.Size(495, 51);
            this.AddToFridgeBtn.TabIndex = 10;
            this.AddToFridgeBtn.Text = "Add to fridge";
            this.AddToFridgeBtn.UseVisualStyleBackColor = true;
            this.AddToFridgeBtn.Click += new System.EventHandler(this.AddToFridgeBtn_Click);
            // 
            // ingredientsGrid
            // 
            this.ingredientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsGrid.Location = new System.Drawing.Point(28, 58);
            this.ingredientsGrid.Name = "ingredientsGrid";
            this.ingredientsGrid.RowHeadersWidth = 62;
            this.ingredientsGrid.RowTemplate.Height = 28;
            this.ingredientsGrid.Size = new System.Drawing.Size(591, 445);
            this.ingredientsGrid.TabIndex = 11;
            this.ingredientsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ingredientsGrid_CellClick);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(28, 8);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(591, 44);
            this.searchTxt.TabIndex = 12;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.Location = new System.Drawing.Point(627, 454);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(495, 51);
            this.clearAllBtn.TabIndex = 14;
            this.clearAllBtn.Text = "Clear All";
            this.clearAllBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.clearAllBtn.UseVisualStyleBackColor = true;
            this.clearAllBtn.Click += new System.EventHandler(this.clearAllBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(623, 394);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(495, 51);
            this.editBtn.TabIndex = 15;
            this.editBtn.Text = "Edit Ingredient";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 534);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.clearAllBtn);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.ingredientsGrid);
            this.Controls.Add(this.AddToFridgeBtn);
            this.Controls.Add(this.PricePer100gNum);
            this.Controls.Add(this.KcalPer100gNum);
            this.Controls.Add(this.WeightNum);
            this.Controls.Add(this.TypeTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "IngredientsForm";
            this.Text = "My fridge";
            this.Load += new System.EventHandler(this.IngredientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeightNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KcalPer100gNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PricePer100gNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox TypeTxt;
        private System.Windows.Forms.NumericUpDown WeightNum;
        private System.Windows.Forms.NumericUpDown KcalPer100gNum;
        private System.Windows.Forms.NumericUpDown PricePer100gNum;
        private System.Windows.Forms.Button AddToFridgeBtn;
        private System.Windows.Forms.DataGridView ingredientsGrid;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button clearAllBtn;
        private System.Windows.Forms.Button editBtn;
    }
}