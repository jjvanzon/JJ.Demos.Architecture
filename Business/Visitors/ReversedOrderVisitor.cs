using JJ.Demos.Architecture.Business.Visitors;
using JJ.Demos.Architecture.Data.Entities;

/// <summary>
/// This Visitor changes the order of processing.
/// </summary>
class ReversedOrderVisitor : OrderVisitorBase
{
    protected override void VisitOrder(Order order)
    {
        foreach (var orderLine in order.OrderLines.ToArray())
        {
            VisitOrderLine(orderLine);
        }

        // Visit Customer and Supplier last instead of first.
        VisitCustomer(order.Customer);
        VisitSupplier(order.Supplier);
    }
}



