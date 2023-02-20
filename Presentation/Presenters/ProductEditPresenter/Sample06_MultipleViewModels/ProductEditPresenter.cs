// Pseudo-code: excluded from compilation

using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductEditViewModels.Sample9_RealisticExample;
using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductListViewModels.Sample2_WithIDAndNames;

namespace JJ.Demos.Architecture.Presentation.Presenters.ProductEditPresenter.Sample06_MultipleViewModels;

class ProductEditPresenter
{
    object Save(ProductEditViewModel userInput)
    {
        if (!successful)
        {
            // Stay in the edit view
            return new ProductEditViewModel();
        }

        // Redirect to list
        return new ProductListViewModel();
    }
}
