using JJ.Demos.Architecture.Data.Entities;

namespace JJ.Demos.Architecture.Business.Visitors;

public class SimpleVisitor
{
    void VisitOrder(Order order)
    {
        VisitCustomer(order.Customer);

        foreach (OrderLine orderLine in order.OrderLines)
        {
            VisitOrderLine(orderLine);
        }
    }


    void VisitCustomer(Customer customer) { }
    void VisitOrderLine(OrderLine orderLine) { }
}
