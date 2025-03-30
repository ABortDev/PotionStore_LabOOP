using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PotionStoreSystem
{
    public partial class SubtractForm : Form
    {
        private string ingredient;
        private int currentQuantity;

        public SubtractForm(string ingredient, string quantity)
        {
            InitializeComponent();
            this.ingredient = ingredient;
            currentQuantity = int.Parse(quantity);
            IngredientShowLabel.Text = ingredient;
            QuantityShowLabel.Text = quantity;
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(SubtractTextBox.Text, out int subtractValue) && subtractValue > 0 && subtractValue <= currentQuantity)
            {
                currentQuantity -= subtractValue;
                UpdateIngredientFile();
                MessageBox.Show("Quantity updated!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid quantity!");
            }
        }

        private void UpdateIngredientFile()
        {
            string[] lines = File.ReadAllLines("Ingredients.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (parts[0] == ingredient)
                {
                    parts[1] = currentQuantity.ToString();
                    lines[i] = string.Join(",", parts);
                    break;
                }
            }
            File.WriteAllLines("Ingredients.txt", lines);
        }
    }
}
