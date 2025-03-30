namespace PotionStoreSystem
{
    partial class CatalogForm
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
            this.PotionList = new System.Windows.Forms.DataGridView();
            this.Potion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Effect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPotionButton = new System.Windows.Forms.Button();
            this.DeletePotionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PotionList)).BeginInit();
            this.SuspendLayout();
            // 
            // PotionList
            // 
            this.PotionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PotionList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PotionList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.PotionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PotionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Potion,
            this.Effect,
            this.Price});
            this.PotionList.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.PotionList.Location = new System.Drawing.Point(12, 12);
            this.PotionList.Name = "PotionList";
            this.PotionList.RowHeadersWidth = 82;
            this.PotionList.RowTemplate.Height = 33;
            this.PotionList.Size = new System.Drawing.Size(776, 327);
            this.PotionList.TabIndex = 0;
            // 
            // Potion
            // 
            this.Potion.HeaderText = "Potion";
            this.Potion.MinimumWidth = 10;
            this.Potion.Name = "Potion";
            this.Potion.Width = 118;
            // 
            // Effect
            // 
            this.Effect.HeaderText = "Effect";
            this.Effect.MinimumWidth = 10;
            this.Effect.Name = "Effect";
            this.Effect.Width = 112;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 10;
            this.Price.Name = "Price";
            this.Price.Width = 106;
            // 
            // AddPotionButton
            // 
            this.AddPotionButton.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPotionButton.Location = new System.Drawing.Point(123, 368);
            this.AddPotionButton.Name = "AddPotionButton";
            this.AddPotionButton.Size = new System.Drawing.Size(262, 51);
            this.AddPotionButton.TabIndex = 1;
            this.AddPotionButton.Text = "Add Potion";
            this.AddPotionButton.UseVisualStyleBackColor = true;
            this.AddPotionButton.Click += new System.EventHandler(this.AddPotionButton_Click);
            // 
            // DeletePotionButton
            // 
            this.DeletePotionButton.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePotionButton.Location = new System.Drawing.Point(404, 368);
            this.DeletePotionButton.Name = "DeletePotionButton";
            this.DeletePotionButton.Size = new System.Drawing.Size(262, 51);
            this.DeletePotionButton.TabIndex = 1;
            this.DeletePotionButton.Text = "Delete Potion";
            this.DeletePotionButton.UseVisualStyleBackColor = true;
            this.DeletePotionButton.Click += new System.EventHandler(this.DeletePotionButton_Click);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeletePotionButton);
            this.Controls.Add(this.AddPotionButton);
            this.Controls.Add(this.PotionList);
            this.Name = "CatalogForm";
            this.Text = "Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.PotionList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PotionList;
        private System.Windows.Forms.Button AddPotionButton;
        private System.Windows.Forms.Button DeletePotionButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Effect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}