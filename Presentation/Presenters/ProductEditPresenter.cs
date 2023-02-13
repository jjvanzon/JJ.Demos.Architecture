using JJ.Demos.Architecture.Business.Calculation;
using JJ.Demos.Architecture.Data.RepositoryInterfaces;
using JJ.Demos.Architecture.Presentation.ViewModels.Screens.
      ProductEditViewModel_Step5_WithVat;

namespace JJ.Demos.Architecture.Presentation.Presenters;

class ProductEditPresenter 
{
    private IProductRepository _productRepository;
    private TaxCalculator _taxCalculator;

    public EditViewModel Show(int id)
    {
        // Data Access
        Product product = _productRepository.Get(id);

        // Business Logic
        decimal price = product.PriceWithoutVat * _taxCalculator.VatFactor;

        // Presentation
        var viewModel = new EditViewModel { Price = price };

        return viewModel;
    }
}
