using JJ.Demos.Architecture.Data.Entities;
using JJ.Demos.Architecture.Data.RepositoryInterfaces;

namespace JJ.Demos.Architecture.Business.Cascading
{
    /// <summary>
    /// Deletes child entities inherently part of the main entity.
    /// </summary>
    public static class DeleteRelatedEntitiesExtensions
    {
        private static IOrderProductRepository _repository;
        private static IAddressRepository _addressRepository;

        public static void DeleteRelatedEntities(this Order order)
        {
            foreach (var orderProduct in order.OrderProducts.ToArray())
            {
                // Call cascading on the child entity too!
                orderProduct.UnlinkRelatedEntities(); 

                _repository.Delete(orderProduct);
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