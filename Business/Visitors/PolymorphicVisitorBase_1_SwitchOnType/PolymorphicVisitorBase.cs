// ReSharper disable once CheckNamespace

namespace JJ.Demos.Architecture.Business.Visitors.
          PolymorphicVisitorBase_1_SwitchOnType;

class PolymorphicVisitorBase
{
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
}
