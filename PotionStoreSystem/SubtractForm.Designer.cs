namespace PotionStoreSystem
{
    partial class SubtractForm
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
            this.IngredientShowLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityShowLabel = new System.Windows.Forms.Label();
            this.SubtractLabel = new System.Windows.Forms.Label();
            this.SubtractTextBox = new System.Windows.Forms.TextBox();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IngredientLabel
            // 
            this.IngredientLabel.AutoSize = true;
            this.IngredientLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientLabel.Location = new System.Drawing.Point(99, 107);
            this.IngredientLabel.Name = "IngredientLabel";
            this.IngredientLabel.Size = new System.Drawing.Size(155, 25);
            this.IngredientLabel.TabIndex = 0;
            this.IngredientLabel.Text = "Ingredient:";
            // 
            // IngredientShowLabel
            // 
            this.IngredientShowLabel.AutoSize = true;
            this.IngredientShowLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientShowLabel.Location = new System.Drawing.Point(260, 107);
            this.IngredientShowLabel.Name = "IngredientShowLabel";
            this.IngredientShowLabel.Size = new System.Drawing.Size(0, 25);
            this.IngredientShowLabel.TabIndex = 0;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(125, 143);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(129, 25);
            this.QuantityLabel.TabIndex = 0;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // QuantityShowLabel
            // 
            this.QuantityShowLabel.AutoSize = true;
            this.QuantityShowLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityShowLabel.Location = new System.Drawing.Point(260, 143);
            this.QuantityShowLabel.Name = "QuantityShowLabel";
            this.QuantityShowLabel.Size = new System.Drawing.Size(0, 25);
            this.QuantityShowLabel.TabIndex = 0;
            // 
            // SubtractLabel
            // 
            this.SubtractLabel.AutoSize = true;
            this.SubtractLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractLabel.Location = new System.Drawing.Point(125, 207);
            this.SubtractLabel.Name = "SubtractLabel";
            this.SubtractLabel.Size = new System.Drawing.Size(129, 25);
            this.SubtractLabel.TabIndex = 0;
            this.SubtractLabel.Text = "Subtract:";
            // 
            // SubtractTextBox
            // 
            this.SubtractTextBox.Location = new System.Drawing.Point(265, 207);
            this.SubtractTextBox.Name = "SubtractTextBox";
            this.SubtractTextBox.Size = new System.Drawing.Size(58, 31);
            this.SubtractTextBox.TabIndex = 1;
            // 
            // SubtractButton
            // 
            this.SubtractButton.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractButton.Location = new System.Drawing.Point(175, 304);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(136, 46);
            this.SubtractButton.TabIndex = 2;
            this.SubtractButton.Text = "Subtract";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // SubtractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(488, 431);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.SubtractTextBox);
            this.Controls.Add(this.QuantityShowLabel);
            this.Controls.Add(this.IngredientShowLabel);
            this.Controls.Add(this.SubtractLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.IngredientLabel);
            this.Name = "SubtractForm";
            this.Text = "Subtract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IngredientLabel;
        private System.Windows.Forms.Label IngredientShowLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label QuantityShowLabel;
        private System.Windows.Forms.Label SubtractLabel;
        private System.Windows.Forms.TextBox SubtractTextBox;
        private System.Windows.Forms.Button SubtractButton;
    }
}