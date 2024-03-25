namespace refit_sample.Models;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public double Price { get; set; }
    public string Description { get; set; } = null!;
    public string Category { get; set; } = null!;
    public string Image { get; set; } = null!;
    public Rating Rating { get; set; } = null!;
}
