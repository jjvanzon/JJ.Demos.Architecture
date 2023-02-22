using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductEditViewModels.Sample9_RealisticExample;

namespace JJ.Demos.Architecture.Presentation.Presenters.ProductEditPresenter.Sample12_ForSocialMedia;

public class ProductEditPresenter
{
    IProductRepository _repository;

    public object Save(ProductEditViewModel userInput)
    {
        // ToEntity
        Product entity = userInput.ToEntity(_repository);

        // Business Logic
        IValidator validator = new ProductValidator(entity);
        if (validator.IsValid)
        {
            new SideEffect_SetDateModified(entity).Execute();

            // Redirect
            return new ProductListViewModel();
        }

        // ToViewModel
        var viewModel = entity.ToEditViewModel();

        // Non-Persisted Data  
        viewModel.Validation.Messages = validator.Messages;

        return viewModel;
    }
}
