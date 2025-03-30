namespace PotionStoreSystem
{
    partial class AddOrderForm
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
            this.PotionComboBox = new System.Windows.Forms.ComboBox();
            this.PotionLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PotionComboBox
            // 
            this.PotionComboBox.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotionComboBox.FormattingEnabled = true;
            this.PotionComboBox.Location = new System.Drawing.Point(230, 120);
            this.PotionComboBox.Name = "PotionComboBox";
            this.PotionComboBox.Size = new System.Drawing.Size(182, 33);
            this.PotionComboBox.TabIndex = 0;
            // 
            // PotionLabel
            // 
            this.PotionLabel.AutoSize = true;
            this.PotionLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotionLabel.Location = new System.Drawing.Point(121, 128);
            this.PotionLabel.Name = "PotionLabel";
            this.PotionLabel.Size = new System.Drawing.Size(103, 25);
            this.PotionLabel.TabIndex = 1;
            this.PotionLabel.Text = "Potion:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(95, 181);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(129, 25);
            this.QuantityLabel.TabIndex = 1;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextBox.Location = new System.Drawing.Point(230, 173);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(63, 33);
            this.QuantityTextBox.TabIndex = 2;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderButton.Location = new System.Drawing.Point(186, 275);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(166, 39);
            this.AddOrderButton.TabIndex = 3;
            this.AddOrderButton.Text = "Add Order";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(530, 427);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PotionLabel);
            this.Controls.Add(this.PotionComboBox);
            this.Name = "AddOrderForm";
            this.Text = "Add Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PotionComboBox;
        private System.Windows.Forms.Label PotionLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Button AddOrderButton;
    }
}