namespace JJ.Demos.Architecture.Business.Services;

public class DiscountAssigner
{
    void AssignDiscounts(Order order)
    {
        var collection =
            order.OrderLines
                 .Where(x => x.Product.Price >= 10)
                 .Where(x => x.Product.Price <= 100);

        foreach (OrderLine orderLine in collection)
        {
            orderLine.DiscountPercentage = 10;
        }
    }
}
