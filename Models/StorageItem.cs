namespace Data;

public class StorageItem : BaseEntity
{
    public int Amount { get; set; }
    
    public Product Product { get; set; }
}