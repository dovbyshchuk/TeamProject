namespace Models;

public class Check : BaseEntity
{
    public Order Order { get; set; }
}