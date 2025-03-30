namespace PotionStoreSystem
{
    partial class OrdersForm
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
            this.OrdersList = new System.Windows.Forms.DataGridView();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PotionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersList)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersList
            // 
            this.OrdersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OrdersList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrdersList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNumber,
            this.PotionName,
            this.Quantity,
            this.PickupDate});
            this.OrdersList.Location = new System.Drawing.Point(12, 12);
            this.OrdersList.Name = "OrdersList";
            this.OrdersList.RowHeadersWidth = 82;
            this.OrdersList.RowTemplate.Height = 33;
            this.OrdersList.Size = new System.Drawing.Size(776, 310);
            this.OrdersList.TabIndex = 0;
            // 
            // OrderNumber
            // 
            this.OrderNumber.HeaderText = "ID";
            this.OrderNumber.MinimumWidth = 10;
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Width = 77;
            // 
            // PotionName
            // 
            this.PotionName.HeaderText = "Potion";
            this.PotionName.MinimumWidth = 10;
            this.PotionName.Name = "PotionName";
            this.PotionName.Width = 118;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 10;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 137;
            // 
            // PickupDate
            // 
            this.PickupDate.HeaderText = "Pickup Date";
            this.PickupDate.MinimumWidth = 10;
            this.PickupDate.Name = "PickupDate";
            this.PickupDate.Width = 173;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderButton.Location = new System.Drawing.Point(167, 364);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(209, 49);
            this.AddOrderButton.TabIndex = 1;
            this.AddOrderButton.Text = "Add Order";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Font = new System.Drawing.Font("Unispace", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOrderButton.Location = new System.Drawing.Point(414, 364);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(221, 49);
            this.DeleteOrderButton.TabIndex = 1;
            this.DeleteOrderButton.Text = "Delete Order";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteOrderButton);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.OrdersList);
            this.Name = "OrdersForm";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.OrdersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PotionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickupDate;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button DeleteOrderButton;
    }
}