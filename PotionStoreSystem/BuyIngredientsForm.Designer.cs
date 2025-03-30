namespace PotionStoreSystem
{
    partial class BuyIngredientsForm
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
            this.IngredientLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PricePerUnitLabel = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.PricePerUnitShowLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.IngredientShowLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IngredientLabel
            // 
            this.IngredientLabel.AutoSize = true;
            this.IngredientLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IngredientLabel.Location = new System.Drawing.Point(66, 95);
            this.IngredientLabel.Name = "IngredientLabel";
            this.IngredientLabel.Size = new System.Drawing.Size(155, 25);
            this.IngredientLabel.TabIndex = 0;
            this.IngredientLabel.Text = "Ingredient:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(91, 160);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(129, 25);
            this.QuantityLabel.TabIndex = 0;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // PricePerUnitLabel
            // 
            this.PricePerUnitLabel.AutoSize = true;
            this.PricePerUnitLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricePerUnitLabel.Location = new System.Drawing.Point(437, 95);
            this.PricePerUnitLabel.Name = "PricePerUnitLabel";
            this.PricePerUnitLabel.Size = new System.Drawing.Size(155, 25);
            this.PricePerUnitLabel.TabIndex = 0;
            this.PricePerUnitLabel.Text = "Price p.u.:";
            // 
            // BuyButton
            // 
            this.BuyButton.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyButton.Location = new System.Drawing.Point(269, 234);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(131, 46);
            this.BuyButton.TabIndex = 1;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // PricePerUnitShowLabel
            // 
            this.PricePerUnitShowLabel.AutoSize = true;
            this.PricePerUnitShowLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricePerUnitShowLabel.ForeColor = System.Drawing.Color.Maroon;
            this.PricePerUnitShowLabel.Location = new System.Drawing.Point(588, 95);
            this.PricePerUnitShowLabel.Name = "PricePerUnitShowLabel";
            this.PricePerUnitShowLabel.Size = new System.Drawing.Size(0, 25);
            this.PricePerUnitShowLabel.TabIndex = 0;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(226, 154);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(74, 31);
            this.QuantityTextBox.TabIndex = 2;
            // 
            // IngredientShowLabel
            // 
            this.IngredientShowLabel.AutoSize = true;
            this.IngredientShowLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientShowLabel.ForeColor = System.Drawing.Color.Maroon;
            this.IngredientShowLabel.Location = new System.Drawing.Point(221, 95);
            this.IngredientShowLabel.Name = "IngredientShowLabel";
            this.IngredientShowLabel.Size = new System.Drawing.Size(0, 25);
            this.IngredientShowLabel.TabIndex = 0;
            // 
            // BuyIngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(665, 337);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.PricePerUnitShowLabel);
            this.Controls.Add(this.PricePerUnitLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.IngredientShowLabel);
            this.Controls.Add(this.IngredientLabel);
            this.Name = "BuyIngredientsForm";
            this.Text = "BuyIngredientsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IngredientLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label PricePerUnitLabel;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Label PricePerUnitShowLabel;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label IngredientShowLabel;
    }
}