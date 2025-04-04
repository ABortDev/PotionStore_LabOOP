namespace PotionStoreSystem
{
    public interface IOrderable
    {
        int Quantity { get; set; }
        string ItemName { get; }
    }
}