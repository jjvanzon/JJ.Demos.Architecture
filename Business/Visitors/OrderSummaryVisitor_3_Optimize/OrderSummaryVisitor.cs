namespace JJ.Demos.Architecture.Business.Visitors.
          OrderSummaryVisitor_3_Optimize;

/// <summary>
/// This Visitor aims to optimize the recursion.
/// </summary>
class OrderSummaryVisitor : OrderVisitorBase
{
    /// <summary>
    /// Override VisitOrder and leave out part of the recursive process.
    /// </summary>
    protected override void VisitOrder(Order order)
    {
        // Customer and Supplier are skipped here for optimization.

        foreach (var orderLine in order.OrderLines.ToArray())
        {
            VisitOrderLine(orderLine);
        }

        // Don't call base here. This method replaced it.
    }
}

