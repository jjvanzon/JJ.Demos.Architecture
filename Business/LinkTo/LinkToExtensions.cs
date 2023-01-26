using JJ.Demos.Architecture.Data.Entities;

namespace JJ.Demos.Architecture.Business.LinkTo
{
    public static class LinkToExtensions
    {
        public static void LinkTo(this Order order, Supplier? supplier)
            => throw new NotImplementedException();

        public static void LinkTo(this OrderLine orderLine, Order? order)
            => throw new NotImplementedException();

        public static void LinkTo(this OrderLine orderLine, Product? order)
            => throw new NotImplementedException();
    }
}
