using JJ.Demos.Architecture.Data.Entities;
using JJ.Demos.Architecture.Data.RepositoryInterfaces;

namespace JJ.Demos.Architecture.Business.Cascading;

/// <summary>
/// Deletes child entities inherently part of the main entity.
/// </summary>
public static class DeleteRelatedEntitiesExtensions
{
    private static IOrderLineRepository _repository;

    public static void DeleteRelatedEntities(this Order order)
    {
        // Delete child entities.
        foreach (var orderLine in order.OrderLines.ToArray())
        {
            // Call cascading on the child entity too!
            orderLine.UnlinkRelatedEntities(); 

            _repository.Delete(orderLine);
        }
    }

    /// <summary>
    /// With repository parameter.
    /// </summary>
    public static void DeleteRelatedEntities(
        this Order order,

        // Repository parameter
        IOrderLineRepository repository)
    {
        foreach (var orderLine in order.OrderLines.ToArray())
        {
            orderLine.UnlinkRelatedEntities();
            repository.Delete(orderLine);
        }
    }
}