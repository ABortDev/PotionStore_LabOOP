using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PotionStoreSystem
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            LoadIngredients();
        }

        private void LoadIngredients()
        {
            IngredientsList.Rows.Clear();
            if (File.Exists("Ingredients.txt"))
            {
                foreach (var line in File.ReadAllLines("Ingredients.txt"))
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        IngredientsList.Rows.Add(parts[0], parts[1], parts[2]);
                    }
                }
            }
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (IngredientsList.SelectedRows.Count > 0)
            {
                var selectedRow = IngredientsList.SelectedRows[0];
                string ingredient = selectedRow.Cells[0].Value.ToString();
                string quantity = selectedRow.Cells[1].Value.ToString();

                SubtractForm subtractForm = new SubtractForm(ingredient, quantity);
                subtractForm.ShowDialog();
                LoadIngredients();
            }
        }

        private void BuyIngredientsButton_Click(object sender, EventArgs e)
        {
            if (IngredientsList.SelectedRows.Count > 0)
            {
                var selectedRow = IngredientsList.SelectedRows[0];
                string ingredient = selectedRow.Cells[0].Value.ToString();
                string pricePerUnit = selectedRow.Cells[2].Value.ToString();

                BuyIngredientsForm buyForm = new BuyIngredientsForm(ingredient, pricePerUnit);
                buyForm.ShowDialog();
                LoadIngredients();
            }
        }
    }
}
