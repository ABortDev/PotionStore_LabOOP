namespace PotionStoreSystem
{
    public interface IInventoryItem
    {
        string Name { get; }
        int Quantity { get; set; }
    }
}
