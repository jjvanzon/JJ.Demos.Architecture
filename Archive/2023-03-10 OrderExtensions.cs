namespace JJ.Demos.Architecture.Business.Extensions;

public static class OrderExtensions
{
    /// <summary>
    /// Calculate the total cost of all the products in the order.
    /// </summary>
    public static decimal GetTotalPrice(this Order order)
        => order.OrderLines
                .Sum(x => x.Quantity *
                          x.Product.Price *
                          1 - x.DiscountPercentage / 100m);
}
