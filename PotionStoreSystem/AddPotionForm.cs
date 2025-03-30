using System;
using System.Collections.Generic;
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
            string effect = EffectTextBox.Text.Trim();
            string price = PriceTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(effect) || string.IsNullOrWhiteSpace(price))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(price, out decimal priceValue))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            Potion newPotion = new Potion(name, effect, priceValue, new List<Ingredient>());
            PotionStore.AddPotion(newPotion);

            File.AppendAllText(filePath, $"{newPotion.PotionName},{newPotion.Effect},{newPotion.Price}" + Environment.NewLine);

            MessageBox.Show("Potion added successfully!");
            this.Close();
        }
    }
}
