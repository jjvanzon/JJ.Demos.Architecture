namespace JJ.Demos.Architecture.Business.Visitors;

/// <summary>
/// Here the Visit methods are extended,
/// creating a text that summarizes the Order.
/// </summary>
class OrderSummaryVisitor_Step2_Extend : OrderVisitorBase
{
    StringBuilder _sb = new();

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
