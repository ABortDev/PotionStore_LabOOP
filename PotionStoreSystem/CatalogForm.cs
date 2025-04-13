using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PotionStoreSystem
{
    public partial class CatalogForm : Form
    {
        private string filePath = "Potions.txt";

        public CatalogForm()
        {
            InitializeComponent();
            LoadPotions();
        }

        private void LoadPotions()
        {
            PotionList.Rows.Clear();
            if (!File.Exists(filePath)) return;

            string[] lines = File.ReadAllLines(filePath);

            //  Лямбда-вираз: спочатку розпарсимо зілля, потім відсортуємо по ціні
            var sortedPotions = lines
                .Select(line => line.Split(','))
                .Where(parts => parts.Length == 3)
                .Select(parts => new
                {
                    Name = parts[0].Trim(),
                    Effect = parts[1].Trim(),
                    Price = decimal.TryParse(parts[2].Trim(), out var price) ? price : 0
                })
                .OrderBy(p => p.Price) // лямбда-вираз
                .ToList();

            // Вивід у таблицю
            foreach (var potion in sortedPotions)
            {
                PotionList.Rows.Add(potion.Name, potion.Effect, potion.Price);
            }
        }


        private void AddPotionButton_Click(object sender, EventArgs e)
        {
            AddPotionForm addPotionForm = new AddPotionForm();
            addPotionForm.FormClosed += (s, args) => LoadPotions(); 
            addPotionForm.Show();
        }

        private void DeletePotionButton_Click(object sender, EventArgs e)
        {
            if (PotionList.SelectedRows.Count > 0)
            {
                string potionName = PotionList.SelectedRows[0].Cells[0].Value.ToString();

                // Анонімний метод
                Action confirmDelete = delegate ()
                {
                    List<string> lines = File.ReadAllLines(filePath).ToList();
                    lines.RemoveAll(line => line.StartsWith(potionName + ","));
                    File.WriteAllLines(filePath, lines);
                    PotionList.Rows.RemoveAt(PotionList.SelectedRows[0].Index);
                };

                // діалог підтвердження
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete '{potionName}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    confirmDelete(); // Викликаємо анонімний метод
                }
            }
            else
            {
                MessageBox.Show("Please select a potion to delete.");
            }
        }

    }
}
