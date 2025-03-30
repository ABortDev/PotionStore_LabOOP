namespace PotionStoreSystem
{
    partial class WelcomeForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.CatalogButton = new System.Windows.Forms.Button();
            this.InventoryButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Sandy Comic Strip", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel.Location = new System.Drawing.Point(250, 105);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(294, 57);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome";
            // 
            // CatalogButton
            // 
            this.CatalogButton.BackColor = System.Drawing.Color.Transparent;
            this.CatalogButton.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatalogButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CatalogButton.Location = new System.Drawing.Point(69, 287);
            this.CatalogButton.Name = "CatalogButton";
            this.CatalogButton.Size = new System.Drawing.Size(203, 56);
            this.CatalogButton.TabIndex = 1;
            this.CatalogButton.Text = "To Catalog";
            this.CatalogButton.UseVisualStyleBackColor = false;
            this.CatalogButton.Click += new System.EventHandler(this.CatalogButton_Click);
            // 
            // InventoryButton
            // 
            this.InventoryButton.BackColor = System.Drawing.Color.Transparent;
            this.InventoryButton.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InventoryButton.Location = new System.Drawing.Point(298, 287);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(203, 56);
            this.InventoryButton.TabIndex = 1;
            this.InventoryButton.Text = "To Inventory";
            this.InventoryButton.UseVisualStyleBackColor = false;
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.BackColor = System.Drawing.Color.Transparent;
            this.OrdersButton.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrdersButton.Location = new System.Drawing.Point(529, 287);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(203, 56);
            this.OrdersButton.TabIndex = 1;
            this.OrdersButton.Text = "To Orders";
            this.OrdersButton.UseVisualStyleBackColor = false;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrdersButton);
            this.Controls.Add(this.InventoryButton);
            this.Controls.Add(this.CatalogButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "WelcomeForm";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button CatalogButton;
        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.Button OrdersButton;
    }
}

