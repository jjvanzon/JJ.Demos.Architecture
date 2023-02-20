using JJ.Demos.Architecture.Presentation.ViewModels.Items.ProductViewModels.Sample6_RealisticExample;
using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductEditViewModels.Sample9_RealisticExample;

namespace JJ.Demos.Architecture.Presentation.ToEntity;

public static class ToEntityExtensions
{
    public static Product ToEntity(
        this ProductEditViewModel viewModel,
        IProductRepository productRepository)
        => viewModel.Product.ToEntity(productRepository);

    public static Product ToEntity(
        this ProductViewModel viewModel,
        IProductRepository productRepository)
    {
        Product product = productRepository.TryGet(viewModel.ID);
        if (product == null)
        {
            product = new Product { ID = viewModel.ID };
            productRepository.Insert(product);
        }

        product.ProductNumber = viewModel.ProductNumber;
        product.Name = viewModel.Name;
        product.Description = viewModel.Description;
        product.PriceWithoutVat = viewModel.Price;

        return product;
    }
}
