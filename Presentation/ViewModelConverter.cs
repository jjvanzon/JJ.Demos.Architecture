using JJ.Demos.Architecture.Presentation.ViewModels.Items.
      ProductViewModel_Step5_WithVat;
using JJ.Demos.Architecture.Presentation.ViewModels.Screens.
      ProductEditViewModel_Step5_WithVat;

namespace JJ.Demos.Architecture.Presentation;

static class ViewModelConverter
{ 
    /// <summary>
    /// Conversion from ViewModel to ViewModel is not recommended.
    /// </summary>
    public static void Convert(
        EditViewModel userInput, ProductViewModel viewModel)
    {
        if (viewModel.HasVat)
        {
            viewModel.Price = userInput.Price * userInput.Vat;
        }
        else
        {
            viewModel.Price = userInput.Price / userInput.Vat;
        }
    }
}
