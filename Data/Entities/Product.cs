namespace JJ.Demos.Architecture.Data.Entities;

public class Product
{
    public virtual int ID { get; set; }
    public virtual string Name { get; set; }
    public virtual string Description { get; set; }
    public virtual ProductType ProductType { get; set; }
    public virtual Category Category { get; set; }
    public IList<Order> Orders { get; set; } = new List<Order>();
}