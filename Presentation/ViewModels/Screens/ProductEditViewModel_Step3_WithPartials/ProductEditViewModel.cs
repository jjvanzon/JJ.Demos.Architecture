using JJ.Demos.Architecture.Presentation.ViewModels.Items.ProductViewModel_Step2_Composite;

namespace JJ.Demos.Architecture.Presentation.ViewModels.Screens.
          ProductEditViewModel_Step3_WithPartials;

/// <summary>
/// Screen ViewModel with Partials
/// </summary>
public class ProductEditViewModel
{
    // Partials
    public ButtonBarViewModel Buttons { get; set; }
    public LoginPartialViewModel Login { get; set; }

    public ProductViewModel Product { get; set; }
    public bool IsNew { get; set; }
    public bool CanDelete { get; set; }
}