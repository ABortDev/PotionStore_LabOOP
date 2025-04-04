using System;
using System.Collections.Generic;

namespace PotionStoreSystem
{
    public sealed class Order : BaseEntity, IDisplayable
    {
        public List<Potion> Potions { get; set; }
        public DateTime PickupDate { get; set; }

        public Order(List<Potion> potions, DateTime pickupDate)
        {
            Potions = potions;
            PickupDate = pickupDate;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Order ID: {Id}, Pickup Date: {PickupDate.ToShortDateString()}");
        }
    }
}
