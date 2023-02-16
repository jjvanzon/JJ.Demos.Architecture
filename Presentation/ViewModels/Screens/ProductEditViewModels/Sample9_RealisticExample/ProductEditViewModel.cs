using JJ.Demos.Architecture.Presentation.ViewModels.Items.ProductViewModels.Sample6_RealisticExample;

namespace JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductEditViewModels.Sample9_RealisticExample;

/// Screen ViewModel
public class ProductEditViewModel
{
    // Entity ViewModel
    public ProductViewModel Product { get; set; }

    // Partial ViewModels
    public ButtonBarViewModel Buttons { get; set; }
    public LoginPartialViewModel Login { get; set; }

    // Lookup ViewModels
    public IList<IDAndName> CategoryLookup { get; set; }
    public IList<IDAndName> ProductTypeLookup { get; set; }

    // Composition
    public ValidationViewModel Validation { get; set; }
}
