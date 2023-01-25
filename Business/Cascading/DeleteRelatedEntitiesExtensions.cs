using JJ.Demos.Architecture.Data.Entities;
using JJ.Demos.Architecture.Data.RepositoryInterfaces;

namespace JJ.Demos.Architecture.Business.Cascading
{
    /// <summary>
    /// Deletes child entities inherently part of the main entity.
    /// </summary>
    public static class DeleteRelatedEntitiesExtensions
    {
        private static IOrderProductRepository _orderProductRepository;
        private static IAddressRepository _addressRepository;

        public static void DeleteRelatedEntities(this Order order)
        {
            foreach (OrderProduct orderProduct in order.OrderProducts.ToArray())
            {
                orderProduct.UnlinkRelatedEntities();
                _orderProductRepository.Delete(orderProduct);
            }
        }

        public static void DeleteRelatedEntities(this Customer customer)
        {
            foreach (Address address in customer.Addresses.ToArray())
            {
                _addressRepository.Delete(address);
            }
        }
    }
}