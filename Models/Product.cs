namespace Models;

public class Product : BaseEntity
{
    public decimal Price { get; set; }
    public double Weight { get; set; }
    public string Name { get; set; }

    public int StorageItemId { get; set; }
    public StorageItem StorageItem { get; set; }
}