using JJ.Demos.Architecture.Presentation.Presenters.ProductEditPresenter.Sample11_CompleteExample;
using JJ.Demos.Architecture.Presentation.ViewModels.Items.ProductViewModels.Sample6_RealisticExample;
using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductEditViewModels.Sample9_RealisticExample;

namespace JJ.Demos.Architecture.Presentation.Tests;

public class ProductEditPresenter_CompleteExample_Tests
{
    [Fact]
    public void Test_ProductEditPresenter_CompleteExample_Save_ValidationSuccessful()
    {
        // Arrange
        IContext context = ContextFactory.CreateContextFromConfiguration();
        IProductRepository repository = RepositoryFactory.CreateRepositoryFromConfiguration<IProductRepository>(context);

        ProductEditPresenter presenter = new(repository);
        ProductEditViewModel userInput = new()
        {
            Product = new ProductViewModel
            {
                ID = 1,
                ProductNumber = "ABC123",
                Name = "Cool Gadget",
                Description = "This is the coolest new gadget. You should really buy it, because it's cool!",
                Price = 8.30m
            }
        };

        // Act
        var viewModelObject = presenter.Save(userInput);

        // Assert
        Assert.IsType<ProductListViewModel>(viewModelObject);

        Product product = repository.TryGet(userInput.Product.ID);
        Assert.NotNull(product);

        Assert.Equal(userInput.Product.ProductNumber, product.ProductNumber);
        Assert.Equal(userInput.Product.Name, product.Name);
        Assert.Equal(userInput.Product.Description, product.Description);
        Assert.Equal(userInput.Product.Price, product.PriceWithoutVat);
        Assert.Equal(SideEffect_SetDateModified.FixedDateTime.Date, product.DateModified);
    }

    [Fact]
    public void Test_ProductEditPresenter_CompleteExample_Save_ValidationFailed()
    {
        // Arrange
        IContext context = ContextFactory.CreateContextFromConfiguration();
        IProductRepository repository = RepositoryFactory.CreateRepositoryFromConfiguration<IProductRepository>(context);

        ProductEditPresenter presenter = new(repository);
        ProductEditViewModel userInput = new()
        {
            Product = new ProductViewModel
            {
                ID = 1,
                ProductNumber = "",
                Name = "",
            }
        };

        // Act
        var viewModelObject = presenter.Save(userInput);

        // Assert
        Assert.IsType<ProductEditViewModel>(viewModelObject);
        var viewModel = (ProductEditViewModel)viewModelObject;

        Assert.Equal(userInput.Product.ID, viewModel.Product.ID);
        Assert.Equal(userInput.Product.ProductNumber, viewModel.Product.ProductNumber);
        Assert.Equal(userInput.Product.Name, viewModel.Product.Name);
        Assert.Equal(userInput.Product.Description, viewModel.Product.Description);
        Assert.Equal(userInput.Product.Price, viewModel.Product.Price);

        Assert.NotNull(viewModel.Validation);
        Assert.NotNull(viewModel.Validation.Messages);
        Assert.True(viewModel.Validation.Messages.Any());
    }
}
