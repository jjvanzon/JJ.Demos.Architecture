using JJ.Demos.Architecture.Business.SideEffects;
using JJ.Demos.Architecture.Data.RepositoryInterfaces;
using JJ.Demos.Architecture.Presentation.Presenters.ProductEditPresenter.Sample11_CompleteExample;
using JJ.Demos.Architecture.Presentation.ViewModels.Items.ProductViewModels.Sample6_RealisticExample;
using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductEditViewModels.Sample9_RealisticExample;
using JJ.Framework.Data;

namespace JJ.Demos.Architecture.Presentation.Tests;

public class ProductEditPresenterTests
{
    [Fact]
    public void Test_ProductEditPresenter_Save_Valid()
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
    public void Test_ProductEditPresenter_Save_ValidationFailed()
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
        Assert.Equal(viewModel.Product.ID, userInput.Product.ID);
        Assert.Equal(viewModel.Product.ProductNumber, userInput.Product.ProductNumber);
        Assert.Equal(viewModel.Product.Name, userInput.Product.Name);
        Assert.Equal(viewModel.Product.Description, userInput.Product.Description);
        Assert.Equal(viewModel.Product.Price, userInput.Product.Price);
        Assert.NotNull(viewModel.Validation);
        Assert.NotNull(viewModel.Validation.Messages);
        Assert.True(viewModel.Validation.Messages.Any());
    }
}
