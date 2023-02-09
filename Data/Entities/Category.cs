namespace JJ.Demos.Architecture.Data.Entities;

public class Category 
{
    public IList<Product> Products { get; set; } = new List<Product>();
}
