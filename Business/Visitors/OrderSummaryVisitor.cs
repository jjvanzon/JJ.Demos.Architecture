using System.Text;
using JJ.Demos.Architecture.Data.Entities;

namespace JJ.Demos.Architecture.Business.Visitors;

class OrderSummaryVisitor : VisitorBase
{
    StringBuilder _sb;

    public string Execute(Order order)
    {
        _sb = new StringBuilder();

        VisitOrder(order);

        return _sb.ToString();
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
