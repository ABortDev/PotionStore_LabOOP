namespace PotionStoreSystem
{
    public class Potion : IPurchasable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Potion(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public void DisplayInfo()
        {
            System.Console.WriteLine($"Name: {Name}\nDescription: {Description}\nPrice: {Price:C}\n");
        }
    }
}
