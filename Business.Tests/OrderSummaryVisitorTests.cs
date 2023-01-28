using JJ.Demos.Architecture.Business.Visitors;
using JJ.Demos.Architecture.Data.Entities;
using static System.Environment;

namespace JJ.Demos.Architecture.Business.Tests;

public class OrderSummaryVisitorTests
{
    [Fact]
    public void Test_SpecializedVisitor()
    {
        var visitor = new OrderSummaryVisitor();

        Order order = CreateOrder();

        string expected = "1 x Cool gadget" + NewLine +
                          "2 x Fidget thingies" + NewLine;
        
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
                    Name = "Cool gadget"
                }
            },
            new()
            {
                Quantity = 2,
                Product = new Product
                {
                    Name = "Fidget thingies"
                }
            }
        }
    };
}
