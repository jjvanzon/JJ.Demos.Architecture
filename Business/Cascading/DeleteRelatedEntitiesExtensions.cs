using JJ.Demos.Architecture.Data.Entities;
using JJ.Demos.Architecture.Data.RepositoryInterfaces;

namespace JJ.Demos.Architecture.Business.Cascading
{
    /// <summary>
    /// Deletes child entities inherently part of the main entity.
    /// </summary>
    public static class DeleteRelatedEntitiesExtensions
    {
        private static IOrderLineRepository _repository;
        private static IAddressRepository _addressRepository;

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

        public static void DeleteRelatedEntities(this Customer customer)
        {
            foreach (var address in customer.Addresses.ToArray())
            {
                _addressRepository.Delete(address);
            }
        }
    }
}