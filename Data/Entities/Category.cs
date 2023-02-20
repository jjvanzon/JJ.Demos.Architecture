namespace JJ.Demos.Architecture.Data.Entities;

public class Category 
{
    public int ID { get; set; }
    public string Name { get; set; }
    public IList<Product> Products { get; set; } = new List<Product>();
}
