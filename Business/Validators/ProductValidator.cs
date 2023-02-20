namespace JJ.Demos.Architecture.Business.Validators;

public class ProductValidator : VersatileValidator
{
    public ProductValidator(Product entity)
    {
        For(entity.Name, nameof(entity.Name)).NotNullOrWhiteSpace();
        For(entity.ProductNumber, nameof(entity.ProductNumber)).NotNullOrWhiteSpace();
    }
}
