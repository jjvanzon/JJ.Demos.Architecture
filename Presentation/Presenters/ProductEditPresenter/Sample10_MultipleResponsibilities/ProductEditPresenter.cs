using JJ.Demos.Architecture.Business.Services;
using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductEditViewModels.Sample9_RealisticExample;

namespace JJ.Demos.Architecture.Presentation.Presenters.ProductEditPresenter.Sample10_MultipleResponsibilities;

class ProductEditPresenter
{
    private IProductRepository _repository;
    private IDateTimeProvider _dateTimeProvider;

    public ProductEditPresenter(
        IProductRepository repository, 
        IDateTimeProvider dateTimeProvider)
    {
        _dateTimeProvider = dateTimeProvider;
        _repository = repository;
    }

    public ProductEditViewModel Save(ProductEditViewModel userInput)
    {
        // ToEntity
        Product entity = userInput.ToEntity(_repository);

        // Business
        new SideEffect_SetDateModified(entity, _dateTimeProvider).Execute();

        // Save
        _repository.Commit();

        // ToViewModel
        ProductEditViewModel viewModel = entity.ToEditViewModel();
        return viewModel;
    }
}
