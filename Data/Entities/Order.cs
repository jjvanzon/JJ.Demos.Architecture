namespace JJ.Demos.Architecture.Data.Entities
{
    public class Order
    {
        public virtual Supplier Supplier { get; set; }
        public virtual IList<OrderProduct> OrderProducts { get; set; } 
                 = new List<OrderProduct>();
    }
}