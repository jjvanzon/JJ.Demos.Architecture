namespace JJ.Demos.Architecture.Business.Visitors.
          OrderSummaryVisitor_Step1_Override;

/// <summary>
/// This specialized Visitor only processes
/// OrderLines and Products,
/// so the respective Visit methods are overridden.
/// </summary>
class OrderSummaryVisitor : OrderVisitorBase
{
    protected override void VisitOrderLine(OrderLine orderLine)
        => base.VisitOrderLine(orderLine);

    protected override void VisitProduct(Product product)
        => base.VisitProduct(product);
}
