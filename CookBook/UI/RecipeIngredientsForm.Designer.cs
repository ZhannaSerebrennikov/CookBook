
namespace CookBook.UI
{
    partial class RecipeIngredientsForm
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
            this.allIngredientsLbx = new System.Windows.Forms.ListBox();
            this.recipeIngredientsLbx = new System.Windows.Forms.ListBox();
            this.addIngredientBtn = new System.Windows.Forms.Button();
            this.removeIngredientBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "All ingredients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recipe ingredients";
            // 
            // allIngredientsLbx
            // 
            this.allIngredientsLbx.FormattingEnabled = true;
            this.allIngredientsLbx.ItemHeight = 45;
            this.allIngredientsLbx.Location = new System.Drawing.Point(32, 90);
            this.allIngredientsLbx.Name = "allIngredientsLbx";
            this.allIngredientsLbx.Size = new System.Drawing.Size(305, 364);
            this.allIngredientsLbx.TabIndex = 2;
            // 
            // recipeIngredientsLbx
            // 
            this.recipeIngredientsLbx.FormattingEnabled = true;
            this.recipeIngredientsLbx.ItemHeight = 45;
            this.recipeIngredientsLbx.Location = new System.Drawing.Point(391, 90);
            this.recipeIngredientsLbx.Name = "recipeIngredientsLbx";
            this.recipeIngredientsLbx.Size = new System.Drawing.Size(305, 364);
            this.recipeIngredientsLbx.TabIndex = 3;
            // 
            // addIngredientBtn
            // 
            this.addIngredientBtn.Location = new System.Drawing.Point(32, 479);
            this.addIngredientBtn.Name = "addIngredientBtn";
            this.addIngredientBtn.Size = new System.Drawing.Size(305, 60);
            this.addIngredientBtn.TabIndex = 4;
            this.addIngredientBtn.Text = "Add ingredient";
            this.addIngredientBtn.UseVisualStyleBackColor = true;
            // 
            // removeIngredientBtn
            // 
            this.removeIngredientBtn.Location = new System.Drawing.Point(391, 479);
            this.removeIngredientBtn.Name = "removeIngredientBtn";
            this.removeIngredientBtn.Size = new System.Drawing.Size(305, 60);
            this.removeIngredientBtn.TabIndex = 5;
            this.removeIngredientBtn.Text = "Remove Ingredient";
            this.removeIngredientBtn.UseVisualStyleBackColor = true;
            // 
            // RecipeIngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 560);
            this.Controls.Add(this.removeIngredientBtn);
            this.Controls.Add(this.addIngredientBtn);
            this.Controls.Add(this.recipeIngredientsLbx);
            this.Controls.Add(this.allIngredientsLbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "RecipeIngredientsForm";
            this.Text = "RecipeIngredientsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox allIngredientsLbx;
        private System.Windows.Forms.ListBox recipeIngredientsLbx;
        private System.Windows.Forms.Button addIngredientBtn;
        private System.Windows.Forms.Button removeIngredientBtn;
    }
}