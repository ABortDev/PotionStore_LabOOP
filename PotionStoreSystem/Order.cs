using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionStoreSystem
{
    public sealed class Order : BaseEntity
    {
        public List<Potion> Potions { get; set; }
        public DateTime PickupDate { get; set; }

        public Order(List<Potion> potions, DateTime pickupDate)
        {
            Potions = potions;
            PickupDate = pickupDate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Order ID: {Id}, Pickup Date: {PickupDate.ToShortDateString()}");
        }
    }
}