using System;
using System.Collections.Generic;

namespace PotionStoreSystem
{
    public class PotionStore
    {
        public delegate void PotionAction(Potion potion);
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

        public static void ProcessPotions(PotionAction action)
        {
            foreach (var potion in potions)
            {
                action(potion);
            }
        }

        public Potion this[int index]
        {
            get { return potions[index]; }
            set { potions[index] = value; }
        }
    }
}
