using JJ.Demos.Architecture.Business.Visitors;
using JJ.Demos.Architecture.Data.Entities;
using static System.Environment;

namespace JJ.Demos.Architecture.Business.Tests;

public class OrderSummaryVisitorTests
{
    [Fact]
    public void Test_SpecializedVisitor()
    {
        var visitor = new OrderSummaryVisitor_Step4_EntryPoint();

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
