namespace JJ.Demos.Architecture.Business.Enums;

public static class EnumExtensions
{
    public static ProductTypeEnum GetProductTypeEnum(this Product product)
    {
        if (product == null) throw new NullException(() => product);
        if (product.ProductType == null) return ProductTypeEnum.Undefined;

        return (ProductTypeEnum)product.ProductType.ID;
    }
}
