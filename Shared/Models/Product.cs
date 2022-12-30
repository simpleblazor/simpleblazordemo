namespace SimpleBlazorDemo.Shared.Models;
public class Product
{
    public Product() { }
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Url { get; set; }

    public int Rating { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
