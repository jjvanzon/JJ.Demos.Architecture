// Pseudo-code: excluded from compilation

using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductEditViewModels.Sample9_RealisticExample;

namespace JJ.Demos.Architecture.Presentation.Presenters.ProductEditPresenter.Sample09_Using_ToViewModel;

public ProductEditViewModel Show(int id)
{
    // Delegate to ToViewModel layer
    var viewModel = entity.ToEditViewModel();
}
