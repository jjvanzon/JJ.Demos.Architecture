using OrderVisitorBaseBase = JJ.Demos.Architecture.Business.Visitors.OrderVisitorBase;

namespace JJ.Demos.Architecture.Business.Visitors.OrderSummaryVisitors.Sample6_ForSocialMedia;

class OrderSummaryVisitor : OrderVisitorBase
{
    protected override void VisitOrderLine(OrderLine orderLine)
    {
        _sb.Append($"{orderLine.Quantity} x ");

        base.VisitOrderLine(orderLine);
    }

    protected override void VisitProduct(Product product)
    {
        _sb.Append($"{product.Name}");
        _sb.AppendLine();

        base.VisitProduct(product);
    }
}

/// <summary>
/// Hides members from the code example above.
/// </summary>
abstract class OrderVisitorBase : OrderVisitorBaseBase
{
    protected StringBuilder _sb = new();

    public string Execute(Order order)
    {
        VisitOrder(order);
        return _sb.ToString();
    }
}