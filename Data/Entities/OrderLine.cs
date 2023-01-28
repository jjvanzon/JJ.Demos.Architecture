namespace JJ.Demos.Architecture.Data.Entities;

public class OrderLine
{
    public virtual int Quantity { get; set; }
    public virtual Product Product { get; set; }
}