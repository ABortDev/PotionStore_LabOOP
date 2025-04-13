using System;
using System.IO;
using System.Windows.Forms;

namespace PotionStoreSystem
{
    public partial class AddPotionForm : Form
    {
        private string filePath = "Potions.txt";

        public AddPotionForm()
        {
            InitializeComponent();
        }

        private void SavePotionButton_Click(object sender, EventArgs e)
        {
            string name = PotionNameTextBox.Text.Trim();
            string description = EffectTextBox.Text.Trim();
            string priceText = PriceTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(priceText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal priceValue))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            Potion newPotion = new Potion(name, description, priceValue);
            PotionStore.AddPotion(newPotion);

            File.AppendAllText(filePath, $"{newPotion.Name},{newPotion.Description},{newPotion.Price}" + Environment.NewLine);

            MessageBox.Show("Potion added successfully!");
            this.Close();
        }
    }
}
