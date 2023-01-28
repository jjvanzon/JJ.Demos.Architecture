using JJ.Demos.Architecture.Data.Entities;

namespace JJ.Demos.Architecture.Business.Visitors;

/// <summary>
/// This Visitor aims to optimize the recursion.
/// </summary>
class OrderSummaryVisitor_Step3_Optimize : OrderVisitorBase
{
    /// <summary>
    /// Override VisitOrder and leave out part of the recursive process.
    /// </summary>
    protected override void VisitOrder(Order order)
    {
        // Customer and Supplier are skipped here for optimization.

        foreach (var orderLine in order.OrderLines)
        {
            VisitOrderLine(orderLine);
        }

        // Don't call base here. This method replaced it.
    }
}

