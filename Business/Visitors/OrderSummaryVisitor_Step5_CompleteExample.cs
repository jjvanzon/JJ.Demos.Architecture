﻿// ReSharper disable once CheckNamespace

namespace JJ.Demos.Architecture.Business.Visitors.
          OrderSummaryVisitor_Step5_CompleteExample;

class OrderSummaryVisitor : OrderVisitorBase
{
    StringBuilder _sb = new();

    public string Execute(Order order)
    {
        VisitOrder(order);
        return _sb.ToString();
    }

    protected override void VisitOrder(Order order)
    {
        foreach (var orderLine in order.OrderLines.ToArray())
        {
            VisitOrderLine(orderLine);
        }
    }

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
