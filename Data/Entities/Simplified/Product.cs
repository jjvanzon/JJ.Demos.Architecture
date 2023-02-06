namespace JJ.Demos.Architecture.Data.Entities.Simplified;

public class Product
{
    public virtual int ID { get; set; }
    public virtual string Name { get; set; }
    public virtual ProductType ProductType { get; set; }
}