using System;
using System.IO;
using System.Windows.Forms;

namespace PotionStoreSystem
{
    public partial class OrdersForm : Form
    {
        private const string OrdersFile = "Orders.txt";

        public OrdersForm()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            OrdersList.Rows.Clear();

            if (File.Exists(OrdersFile))
            {
                string[] orders = File.ReadAllLines(OrdersFile);
                foreach (string order in orders)
                {
                    string[] data = order.Split(',');
                    if (data.Length == 4)
                    {
                        OrdersList.Rows.Add(data[0], data[1], data[2], data[3]);
                    }
                }
            }
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm();
            addOrderForm.Owner = this;
            addOrderForm.ShowDialog();
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            if (OrdersList.SelectedRows.Count > 0)
            {
                int rowIndex = OrdersList.SelectedRows[0].Index;
                OrdersList.Rows.RemoveAt(rowIndex);
                SaveOrdersToFile();
            }
        }

        private void SaveOrdersToFile()
        {
            using (StreamWriter writer = new StreamWriter(OrdersFile))
            {
                foreach (DataGridViewRow row in OrdersList.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string order = $"{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value},{row.Cells[3].Value}";
                        writer.WriteLine(order);
                    }
                }
            }
        }
    }
}
