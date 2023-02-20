using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductEditViewModels.Sample9_RealisticExample;
using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductListViewModels.Sample2_WithIDAndNames;

namespace JJ.Demos.Architecture.Presentation.Presenters.ProductEditPresenter.Sample11_CompleteExample;

class ProductEditPresenter
{
    private IContext _context;
    private IProductRepository _repository;

    public ProductEditPresenter()
    {
        _context = ContextFactory.CreateContextFromConfiguration();
        _repository = RepositoryFactory.CreateRepositoryFromConfiguration< IProductRepository>(_context);
    }

    public object Save(ProductEditViewModel userInput)
    {
        // Security
        SecurityAsserter.AssertLogIn();

        // ToEntity
        Product entity = userInput.ToEntity(_repository);

        // Business
        IValidator validator = new ProductValidator(entity);
        if (validator.IsValid)
        {
            new SideEffect_SetDateModified(entity).Execute();

            // Save
            _repository.Commit();

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
