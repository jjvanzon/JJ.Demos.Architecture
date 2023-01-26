using JJ.Demos.Architecture.Business.LinkTo;
using JJ.Demos.Architecture.Data.Entities;

namespace JJ.Demos.Architecture.Business.Cascading;

/// <summary>
/// Unlinks related entities, not inherently part of the main entity.
/// </summary>
public static class UnlinkRelatedEntitiesExtensions
{
    public static void UnlinkRelatedEntities(this Order order) 
        => order.UnlinkSupplier();

    public static void UnlinkRelatedEntities(this OrderLine orderLine)
    {
        orderLine.UnlinkOrder();
        orderLine.UnlinkProduct();
    }
}
