namespace JJ.Demos.Architecture.Data.Entities.Customer_NoInheritance;

public class Customer
{
    public virtual int ID { get; set; }
    public virtual string Name { get; set; }
    public virtual string CustomerNumber { get; set; }
}