using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PotionStoreSystem
{
    public partial class BuyIngredientsForm : Form
    {
        private string ingredient;
        private int pricePerUnit;

        public BuyIngredientsForm(string ingredient, string pricePerUnit)
        {
            InitializeComponent();
            this.ingredient = ingredient;
            this.pricePerUnit = int.Parse(pricePerUnit);
            IngredientShowLabel.Text = ingredient;
            PricePerUnitShowLabel.Text = pricePerUnit;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(QuantityTextBox.Text, out int quantity) && quantity > 0)
            {
                UpdateIngredientFile(quantity);
                MessageBox.Show("Purchase successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid quantity!");
            }
        }

        private void UpdateIngredientFile(int quantityToAdd)
        {
            string[] lines = File.ReadAllLines("Ingredients.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (parts[0] == ingredient)
                {
                    parts[1] = (int.Parse(parts[1]) + quantityToAdd).ToString();
                    lines[i] = string.Join(",", parts);
                    break;
                }
            }
            File.WriteAllLines("Ingredients.txt", lines);
        }
    }
}
