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
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    PotionList.Rows.Add(parts[0].Trim(), parts[1].Trim(), parts[2].Trim());
                }
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

                // Видаляємо зілля з файлу
                List<string> lines = File.ReadAllLines(filePath).ToList();
                lines.RemoveAll(line => line.StartsWith(potionName + ","));
                File.WriteAllLines(filePath, lines);

                // Видаляємо рядок із таблиці
                PotionList.Rows.RemoveAt(PotionList.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please select a potion to delete.");
            }
        }
    }
}
