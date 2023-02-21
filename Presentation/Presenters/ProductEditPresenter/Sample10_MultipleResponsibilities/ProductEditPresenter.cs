using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductEditViewModels.Sample9_RealisticExample;

namespace JJ.Demos.Architecture.Presentation.Presenters.ProductEditPresenter.Sample10_MultipleResponsibilities;

class ProductEditPresenter
{
    private IProductRepository _repository;

    public ProductEditPresenter(IProductRepository repository)
        => _repository = repository;

    /// <summary>
    /// An action method with multiple responsibilities.
    /// </summary>
    public ProductEditViewModel Save(ProductEditViewModel userInput)
    {
        // ToEntity
        Product entity = userInput.ToEntity(_repository);

        // Business
        new SideEffect_SetDateModified(entity).Execute();

        // Save
        _repository.Commit();

        // ToViewModel
        ProductEditViewModel viewModel = entity.ToEditViewModel();
        return viewModel;
    }
}
