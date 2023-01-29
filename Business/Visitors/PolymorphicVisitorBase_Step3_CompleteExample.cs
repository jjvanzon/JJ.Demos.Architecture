using JJ.Demos.Architecture.Business.Enums;
using JJ.Demos.Architecture.Data.Entities;
using JJ.Framework.Exceptions.InvalidValues;
using JJ.Framework.Exceptions.TypeChecking;

namespace JJ.Demos.Architecture.Business.Visitors;

class PolymorphicVisitorBase_Step3_CompleteExample
{
    protected virtual void VisitOrder(Order order)
    {
        VisitPartyPolymorphic(order.Customer);
        VisitPartyPolymorphic(order.Supplier);
        VisitOrderLines(order.OrderLines);
    }

    protected virtual void VisitPartyPolymorphic(Party party)
    {
        switch (party)
        {
            case Supplier supplier:
                VisitSupplier(supplier);
                break;

            case Customer customer:
                VisitCustomer(customer);
                break;
        }
    }

    protected virtual void VisitSupplier(Supplier supplier)
        => VisitPartyBase(supplier);

    protected virtual void VisitCustomer(Customer customer)
        => VisitPartyBase(customer);

    protected virtual void VisitPartyBase(Party party) { }

    protected virtual void VisitOrderLines(IList<OrderLine> orderLines)
    {
        foreach (OrderLine orderLine in orderLines)
        {
            VisitOrderLine(orderLine);
        }
    }

    protected virtual void VisitOrderLine(OrderLine orderLine)
        => VisitProductPolymorphic(orderLine.Product);

    protected virtual void VisitProductPolymorphic(Product product)
    {
        var productTypeEnum = product.GetProductTypeEnum();
        switch (productTypeEnum)
        {
            case ProductTypeEnum.Physical:
                VisitPhysicalProduct(product);
                break;

            case ProductTypeEnum.Digital:
                VisitDigitalProduct(product);
                break;
        }
    }

    protected virtual void VisitPhysicalProduct(Product product)
        => VisitProductBase(product);

    protected virtual void VisitDigitalProduct(Product product)
        => VisitProductBase(product);

    protected virtual void VisitProductBase(Product product) { }
}
