namespace JJ.Demos.Architecture.Business.Visitors;

class OrderVisitorBase
{
    /// <summary>
    /// VisitOrder processes the child objects:
    /// Customer, Supplier and OrderLines.
    /// </summary>
    protected virtual void VisitOrder(Order order)
    {
        VisitCustomer(order.Customer);
        VisitSupplier(order.Supplier);

        foreach (var orderLine in order.OrderLines.ToArray())
        {
            VisitOrderLine(orderLine);
        }
    }

    /// <summary>
    /// VisitOrderLine also processes its child object: Product.
    /// </summary>
    protected virtual void VisitOrderLine(OrderLine orderLine)
        => VisitProduct(orderLine.Product);


    protected virtual void VisitCustomer(Customer customer) { }
    protected virtual void VisitSupplier(Supplier supplier) { }
    protected virtual void VisitProduct(Product product) { }
}
