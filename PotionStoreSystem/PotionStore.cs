using System;
using System.Collections.Generic;
using System.Linq;

namespace PotionStoreSystem
{
    public class PotionStore
    {
        // Делегат та подія
        public delegate void PotionAction(Potion potion);
        public static event PotionAction PotionAdded;

        private static List<Potion> potions = new List<Potion>();

        // Індексатор
        public Potion this[int index]
        {
            get
            {
                if (index >= 0 && index < potions.Count)
                    return potions[index];
                throw new IndexOutOfRangeException("Invalid potion index.");
            }
            set
            {
                if (index >= 0 && index < potions.Count)
                    potions[index] = value;
                else
                    throw new IndexOutOfRangeException("Invalid potion index.");
            }
        }

        public static void AddPotion(Potion potion)
        {
            potions.Add(potion);

            // Виклик події з використанням анонімного методу, якщо підписано
            PotionAdded?.Invoke(potion);
        }

        public static void DisplayPotions()
        {
            foreach (var potion in potions)
            {
                potion.DisplayInfo();
            }
        }

        // Приклад лямбда-функції для фільтрації зіль за ціною
        public static List<Potion> GetAffordablePotions(decimal maxPrice)
        {
            return potions.Where(p => p.Price <= maxPrice).ToList();
        }
    }
}
