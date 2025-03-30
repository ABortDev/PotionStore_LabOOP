namespace PotionStoreSystem
{
    partial class AddPotionForm
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
            this.PotionNameLabel = new System.Windows.Forms.Label();
            this.EffectLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PotionNameTextBox = new System.Windows.Forms.TextBox();
            this.EffectTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.GoldLabel = new System.Windows.Forms.Label();
            this.SavePotionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PotionNameLabel
            // 
            this.PotionNameLabel.AutoSize = true;
            this.PotionNameLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotionNameLabel.Location = new System.Drawing.Point(87, 114);
            this.PotionNameLabel.Name = "PotionNameLabel";
            this.PotionNameLabel.Size = new System.Drawing.Size(103, 25);
            this.PotionNameLabel.TabIndex = 0;
            this.PotionNameLabel.Text = "Potion:";
            // 
            // EffectLabel
            // 
            this.EffectLabel.AutoSize = true;
            this.EffectLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EffectLabel.Location = new System.Drawing.Point(87, 165);
            this.EffectLabel.Name = "EffectLabel";
            this.EffectLabel.Size = new System.Drawing.Size(103, 25);
            this.EffectLabel.TabIndex = 0;
            this.EffectLabel.Text = "Effect:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(100, 216);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(90, 25);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price:";
            // 
            // PotionNameTextBox
            // 
            this.PotionNameTextBox.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotionNameTextBox.Location = new System.Drawing.Point(196, 108);
            this.PotionNameTextBox.Name = "PotionNameTextBox";
            this.PotionNameTextBox.Size = new System.Drawing.Size(146, 33);
            this.PotionNameTextBox.TabIndex = 1;
            // 
            // EffectTextBox
            // 
            this.EffectTextBox.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EffectTextBox.Location = new System.Drawing.Point(196, 159);
            this.EffectTextBox.Name = "EffectTextBox";
            this.EffectTextBox.Size = new System.Drawing.Size(146, 33);
            this.EffectTextBox.TabIndex = 1;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextBox.Location = new System.Drawing.Point(196, 210);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(73, 33);
            this.PriceTextBox.TabIndex = 1;
            // 
            // GoldLabel
            // 
            this.GoldLabel.AutoSize = true;
            this.GoldLabel.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldLabel.Location = new System.Drawing.Point(278, 216);
            this.GoldLabel.Name = "GoldLabel";
            this.GoldLabel.Size = new System.Drawing.Size(64, 25);
            this.GoldLabel.TabIndex = 0;
            this.GoldLabel.Text = "gold";
            // 
            // SavePotionButton
            // 
            this.SavePotionButton.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePotionButton.Location = new System.Drawing.Point(151, 334);
            this.SavePotionButton.Name = "SavePotionButton";
            this.SavePotionButton.Size = new System.Drawing.Size(147, 45);
            this.SavePotionButton.TabIndex = 2;
            this.SavePotionButton.Text = "Save";
            this.SavePotionButton.UseVisualStyleBackColor = true;
            this.SavePotionButton.Click += new System.EventHandler(this.SavePotionButton_Click);
            // 
            // AddPotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(434, 438);
            this.Controls.Add(this.SavePotionButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.EffectTextBox);
            this.Controls.Add(this.PotionNameTextBox);
            this.Controls.Add(this.GoldLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.EffectLabel);
            this.Controls.Add(this.PotionNameLabel);
            this.Name = "AddPotionForm";
            this.Text = "Add Potion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PotionNameLabel;
        private System.Windows.Forms.Label EffectLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PotionNameTextBox;
        private System.Windows.Forms.TextBox EffectTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label GoldLabel;
        private System.Windows.Forms.Button SavePotionButton;
    }
}