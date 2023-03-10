namespace JJ.Demos.Architecture.Business.Services;

public class DiscountAssigner
{
    void AssignDiscounts(Order order)
    {
        var selection =
            order.OrderLines
                 .Where(x => x.Product.Price >= 10)
                 .Where(x => x.Product.Price <= 100);

        foreach (OrderLine orderLine in selection)
        {
            orderLine.DiscountPercentage = 10;
        }
    }
}
