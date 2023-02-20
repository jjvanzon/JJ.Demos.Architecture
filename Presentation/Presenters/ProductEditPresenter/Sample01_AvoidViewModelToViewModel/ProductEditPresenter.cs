using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductEditViewModels.Sample5_WithVat;

namespace JJ.Demos.Architecture.Presentation.Presenters.ProductEditPresenter.Sample01_AvoidViewModelToViewModel;

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
