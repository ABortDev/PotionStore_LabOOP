using System;
using System.Collections.Generic;

namespace PotionStoreSystem
{
    public class Potion : BaseEntity, IDisplayable
    {
        public string PotionName { get; set; }
        public decimal Price { get; set; }
        public string Effect { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Potion(string potionName, string effect, decimal price, List<Ingredient> ingredients)
        {
            PotionName = potionName;
            Effect = effect;
            Price = price;
            Ingredients = ingredients;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Potion: {PotionName}, Effect: {Effect}, Price: {Price} gold");
        }
    }
}
