namespace JJ.Demos.Architecture.Data.Entities;

public class Order
{
    public virtual Supplier Supplier { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual IList<OrderLine> OrderLines { get; set; } 
        = new List<OrderLine>();
}