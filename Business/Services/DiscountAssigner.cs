namespace JJ.Demos.Architecture.Business.Services;

public class DiscountAssigner
{
    public void AssignDiscounts(Order order)
    {
        // Get order lines with a product price at least 0 and at most 100.
        IList<OrderLine> orderLines =
            order.OrderLines
                 .Where(x => x.Product.Price >= 10)
                 .Where(x => x.Product.Price <= 100)
                 .ToList();

        // Fill in a discount percentage to get 10% off on these products.
        foreach (OrderLine orderLine in orderLines)
        {
            orderLine.DiscountPercentage = 10;
        }
    }
}
