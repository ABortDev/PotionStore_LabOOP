using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionStoreSystem
{
    public abstract class BaseEntity
    {
        public int Id { get; protected set; }
        public static int Counter { get; private set; } = 0;

        protected BaseEntity()
        {
            Id = ++Counter;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Entity ID: {Id}");
        }
    }
}