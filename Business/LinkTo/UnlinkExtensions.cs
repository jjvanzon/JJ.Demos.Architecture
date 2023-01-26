using JJ.Demos.Architecture.Data.Entities;

namespace JJ.Demos.Architecture.Business.LinkTo
{
    public static class UnlinkExtensions
    {
        public static void UnlinkSupplier(this Order order)
            => order.LinkTo((Supplier?)null);

        public static void UnlinkOrder(this OrderLine orderProduct)
            => orderProduct.LinkTo((Order?)null);

        public static void UnlinkProduct(this OrderLine orderProduct)
            => orderProduct.LinkTo((Product?)null);
    }
}
