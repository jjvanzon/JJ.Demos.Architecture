namespace JJ.Demos.Architecture.Business.Visitors.
          VisitMethods_1_Entities;

class OrderVisitor
{
    void VisitOrder(Order order) { }
    void VisitOrderLine(OrderLine orderLine) { }
    void VisitProduct(Product product) { }
}
