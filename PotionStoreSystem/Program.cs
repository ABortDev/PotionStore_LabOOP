using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotionStoreSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm());

            // Анонімний метод
            PotionStore.ProcessPotions(delegate (Potion p)
            {
                Console.WriteLine($"Processing potion: {p.PotionName}");
            });

            // Лямбда-вираз
            PotionStore.ProcessPotions(p => Console.WriteLine($"Lambda processing potion: {p.PotionName}"));
        }
    }
}
