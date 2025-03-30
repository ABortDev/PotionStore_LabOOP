using System;
using System.Windows.Forms;

namespace PotionStoreSystem
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void CatalogButton_Click(object sender, EventArgs e)
        {
            OpenForm(new CatalogForm());
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            OpenForm(new InventoryForm());
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            OpenForm(new OrdersForm());
        }

        private void OpenForm(Form form)
        {
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }
    }
}