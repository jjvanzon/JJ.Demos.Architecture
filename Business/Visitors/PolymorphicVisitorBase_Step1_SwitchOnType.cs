using JJ.Demos.Architecture.Data.Entities;
using JJ.Framework.Exceptions.TypeChecking;

namespace JJ.Demos.Architecture.Business.Visitors;

public abstract class PolymorphicVisitorBase_Step1_SwitchOnType
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
