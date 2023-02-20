using JJ.Demos.Architecture.Business.Services;
using JJ.Demos.Architecture.Data.RepositoryInterfaces;
using JJ.Demos.Architecture.Presentation.Presenters.ProductEditPresenter.Sample11_CompleteExample;
using JJ.Demos.Architecture.Presentation.ViewModels.Items.ProductViewModels.Sample6_RealisticExample;
using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductEditViewModels.Sample9_RealisticExample;
using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductListViewModels.Sample2_WithIDAndNames;
using JJ.Framework.Data;

namespace JJ.Demos.Architecture.Presentation.Tests;

public class ProductEditPresenterTests
{
    [Fact]
    public void Test_ProductEditPresenter_Success()
    {
        // Arrange
        IContext context = ContextFactory.CreateContextFromConfiguration();
        IProductRepository repository = RepositoryFactory.CreateRepositoryFromConfiguration<IProductRepository>(context);
        IDateTimeProvider dateTimeProvider = new FixedDateTimeProvider(DateTime.UtcNow);;

        ProductEditPresenter presenter = new(repository, dateTimeProvider);
        ProductEditViewModel userInput = CreateViewModel();

        // Act
        var viewModelObject = presenter.Save(userInput);

        // Assert
        Assert.IsType<ProductListViewModel>(viewModelObject);
        var viewModel = (ProductListViewModel)viewModelObject;
        Product product = repository.Get(userInput.Product.ID);

        // Assert SideEffect
        Assert.Equal(product.DateModified, dateTimeProvider.UtcNow.Date);

        throw new NotImplementedException();
    }

    private ProductEditViewModel CreateViewModel() =>
        new()
        {
            Product = new ProductViewModel
            {
                ID = 1,
                ProductNumber = "ABC123",
                Name = "Cool Gadget",
                Description = "This is the coolest new gadget. You should really buy it, because it is cool!",
                Price = 8.30m
            }
        };
}