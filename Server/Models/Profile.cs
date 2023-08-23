namespace FakeStore.Models;

public class Profile 
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<Product>? Wishlist { get; set; }
}