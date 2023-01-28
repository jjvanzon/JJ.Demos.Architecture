using System.Text;
using JJ.Demos.Architecture.Data.Entities;

namespace JJ.Demos.Architecture.Business.Visitors;

class SpecializedVisitor : VisitorBase
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
