using System;
using System.Collections.Generic;

namespace PotionStoreSystem
{
    public class PotionStore
    {
        private static List<Potion> potions = new List<Potion>();

        public static void AddPotion(Potion potion)
        {
            potions.Add(potion);
        }

        public static void DisplayPotions()
        {
            foreach (var potion in potions)
            {
                potion.DisplayInfo();
            }
        }
    }
}