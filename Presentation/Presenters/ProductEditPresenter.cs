using JJ.Demos.Architecture.Business.Calculation;
using JJ.Demos.Architecture.Data.RepositoryInterfaces;
using JJ.Demos.Architecture.Presentation.ViewModels.Screens.
      ProductEditViewModel_5_WithVat;

namespace JJ.Demos.Architecture.Presentation.Presenters;

class ProductEditPresenter 
{
    private IProductRepository _repository;
    private TaxCalculator _taxCalculator;

    public EditViewModel Show(int id)
    {
        Product entity = _repository.Get(id);

        decimal price = entity.PriceWithoutVat * _taxCalculator.VatFactor;

        var viewModel = new EditViewModel { Price = price };

        return viewModel;
    }
}
