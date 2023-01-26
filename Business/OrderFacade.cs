using JJ.Demos.Architecture.Business.Cascading;
using JJ.Demos.Architecture.Data.Entities;
using JJ.Demos.Architecture.Data.RepositoryInterfaces;

namespace JJ.Demos.Architecture.Business;

public class OrderFacade
{
    private IOrderRepository _repository;

    public void Delete(Order entity)
    {
        entity.DeleteRelatedEntities();
        entity.UnlinkRelatedEntities();

        // Delete main entity separately.
        _repository.Delete(entity);
    }
}