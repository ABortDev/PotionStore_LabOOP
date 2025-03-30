using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PotionStoreSystem
{
    public partial class AddOrderForm : Form
    {
        private string ordersFile = "Orders.txt";
        private string potionsFile = "Potions.txt";

        public AddOrderForm()
        {
            InitializeComponent();
            LoadPotions();
        }

        private void LoadPotions()
        {
            if (File.Exists(potionsFile))
            {
                var potionNames = File.ReadAllLines(potionsFile)
                                      .Select(line => line.Split(',')[0])
                                      .ToList();
                PotionComboBox.Items.AddRange(potionNames.ToArray());
            }
        }

        private int GetNextOrderNumber()
        {
            if (!File.Exists(ordersFile)) return 1;
            var lines = File.ReadAllLines(ordersFile);
            if (lines.Length == 0) return 1;
            return lines.Length + 1;
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            if (PotionComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(QuantityTextBox.Text))
            {
                MessageBox.Show("Please select a potion and enter quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(QuantityTextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string potionName = PotionComboBox.SelectedItem.ToString();
            int orderNumber = GetNextOrderNumber();
            string pickupDate = DateTime.Now.AddDays(14).ToString("yyyy-MM-dd");

            string newOrder = $"{orderNumber}, {potionName}, {quantity}, {pickupDate}";
            File.AppendAllText(ordersFile, newOrder + Environment.NewLine);

            MessageBox.Show("Order added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
