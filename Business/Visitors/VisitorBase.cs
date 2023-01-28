using JJ.Demos.Architecture.Data.Entities;

namespace JJ.Demos.Architecture.Business.Visitors;

class VisitorBase
{
    protected virtual void VisitOrder(Order order)
    {
        VisitCustomer(order.Customer);
        VisitSupplier(order.Supplier);

        foreach (var orderLine in order.OrderLines)
        {
            VisitOrderLine(orderLine);
        }
    }

    protected virtual void VisitCustomer(Customer customer) { }
    protected virtual void VisitSupplier(Supplier supplier) { }

    protected virtual void VisitOrderLine(OrderLine orderLine)
        => VisitProduct(orderLine.Product);

    protected virtual void VisitProduct(Product product) { }
}
