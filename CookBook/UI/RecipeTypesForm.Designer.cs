
namespace CookBook.UI
{
    partial class RecipeTypesForm
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
            this.typeLbl = new System.Windows.Forms.Label();
            this.newTypeTxt = new System.Windows.Forms.TextBox();
            this.recipeTypesLbx = new System.Windows.Forms.ListBox();
            this.addRecipeTypeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(24, 34);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(95, 45);
            this.typeLbl.TabIndex = 0;
            this.typeLbl.Text = "Type:";
            // 
            // newTypeTxt
            // 
            this.newTypeTxt.Location = new System.Drawing.Point(161, 31);
            this.newTypeTxt.Name = "newTypeTxt";
            this.newTypeTxt.Size = new System.Drawing.Size(215, 50);
            this.newTypeTxt.TabIndex = 1;
            // 
            // recipeTypesLbx
            // 
            this.recipeTypesLbx.FormattingEnabled = true;
            this.recipeTypesLbx.ItemHeight = 45;
            this.recipeTypesLbx.Location = new System.Drawing.Point(32, 99);
            this.recipeTypesLbx.Name = "recipeTypesLbx";
            this.recipeTypesLbx.Size = new System.Drawing.Size(344, 364);
            this.recipeTypesLbx.TabIndex = 2;
            // 
            // addRecipeTypeBtn
            // 
            this.addRecipeTypeBtn.Location = new System.Drawing.Point(32, 482);
            this.addRecipeTypeBtn.Name = "addRecipeTypeBtn";
            this.addRecipeTypeBtn.Size = new System.Drawing.Size(344, 52);
            this.addRecipeTypeBtn.TabIndex = 3;
            this.addRecipeTypeBtn.Text = "Add";
            this.addRecipeTypeBtn.UseVisualStyleBackColor = true;
            this.addRecipeTypeBtn.Click += new System.EventHandler(this.addRecipeTypeBtn_Click);
            // 
            // RecipeTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 568);
            this.Controls.Add(this.addRecipeTypeBtn);
            this.Controls.Add(this.recipeTypesLbx);
            this.Controls.Add(this.newTypeTxt);
            this.Controls.Add(this.typeLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "RecipeTypesForm";
            this.Text = "RecipeTypesForm";
            this.Load += new System.EventHandler(this.RecipeTypesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.TextBox newTypeTxt;
        private System.Windows.Forms.ListBox recipeTypesLbx;
        private System.Windows.Forms.Button addRecipeTypeBtn;
    }
}