﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionStoreSystem
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }

        public Ingredient(string name, int quantity, decimal pricePerUnit)
        {
            Name = name;
            Quantity = quantity;
            PricePerUnit = pricePerUnit;
        }

    }
}