namespace PotionStoreSystem
{
    partial class InventoryForm
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
            this.IngredientsList = new System.Windows.Forms.DataGridView();
            this.IngredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyIngredientsButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientsList)).BeginInit();
            this.SuspendLayout();
            // 
            // IngredientsList
            // 
            this.IngredientsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.IngredientsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.IngredientsList.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.IngredientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngredientsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IngredientName,
            this.Quantity,
            this.PricePerUnit});
            this.IngredientsList.GridColor = System.Drawing.Color.RosyBrown;
            this.IngredientsList.Location = new System.Drawing.Point(12, 12);
            this.IngredientsList.Name = "IngredientsList";
            this.IngredientsList.RowHeadersWidth = 82;
            this.IngredientsList.RowTemplate.Height = 33;
            this.IngredientsList.Size = new System.Drawing.Size(776, 308);
            this.IngredientsList.TabIndex = 0;
            // 
            // IngredientName
            // 
            this.IngredientName.HeaderText = "Ingredient";
            this.IngredientName.MinimumWidth = 10;
            this.IngredientName.Name = "IngredientName";
            this.IngredientName.Width = 152;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 10;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 137;
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.HeaderText = "Price p.u.";
            this.PricePerUnit.MinimumWidth = 10;
            this.PricePerUnit.Name = "PricePerUnit";
            this.PricePerUnit.Width = 148;
            // 
            // BuyIngredientsButton
            // 
            this.BuyIngredientsButton.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyIngredientsButton.Location = new System.Drawing.Point(419, 356);
            this.BuyIngredientsButton.Name = "BuyIngredientsButton";
            this.BuyIngredientsButton.Size = new System.Drawing.Size(146, 54);
            this.BuyIngredientsButton.TabIndex = 1;
            this.BuyIngredientsButton.Text = "Buy";
            this.BuyIngredientsButton.UseVisualStyleBackColor = true;
            this.BuyIngredientsButton.Click += new System.EventHandler(this.BuyIngredientsButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractButton.Location = new System.Drawing.Point(233, 356);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(146, 54);
            this.SubtractButton.TabIndex = 1;
            this.SubtractButton.Text = "Subtract";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.BuyIngredientsButton);
            this.Controls.Add(this.IngredientsList);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.IngredientsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView IngredientsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.Button BuyIngredientsButton;
        private System.Windows.Forms.Button SubtractButton;
    }
}