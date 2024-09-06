namespace API.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public long Price { get; set; } // based on the payment provider that is used
    public string PictureUrl { get; set; }
    public string Type { get; set; }
    public string Brand { get; set; }
    public int QuantityInStock { get; set; }
}