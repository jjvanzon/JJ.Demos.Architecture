using JJ.Demos.Architecture.Business.Visitors.OrderSummaryVisitors.Sample6_ForSocialMedia;

namespace JJ.Demos.Architecture.Business.Tests;

public class OrderSummaryVisitor_ForSocialMedia_Tests
{
    [Fact]
    public void Test_OrderSummaryVisitor_ForSocialMedioa()
    {
        var visitor = new OrderSummaryVisitor();

        Order order = CreateOrder();

        string expected = "1 x Cool Gadget" + NewLine +
                          "2 x Fidget Thing" + NewLine;
        
        string actual = visitor.Execute(order);

        Assert.Equal(expected, actual);
    }

    private static Order CreateOrder() => new Order
    {
        OrderLines = new List<OrderLine>
        {
            new()
            {
                Quantity = 1,
                Product = new Product
                {
                    Name = "Cool Gadget"
                }
            },
            new()
            {
                Quantity = 2,
                Product = new Product
                {
                    Name = "Fidget Thing"
                }
            }
        }
    };
}
