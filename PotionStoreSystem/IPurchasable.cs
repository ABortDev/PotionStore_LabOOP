namespace PotionStoreSystem
{
    public interface IPurchasable
    {
        decimal Price { get; }
        void DisplayInfo();
    }
}
