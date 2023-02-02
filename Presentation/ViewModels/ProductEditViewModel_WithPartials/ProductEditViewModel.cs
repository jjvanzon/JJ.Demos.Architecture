using JJ.Demos.Architecture.Presentation.ViewModels.Items.
      ProductViewModel_Composite;

namespace JJ.Demos.Architecture.Presentation.ViewModels.
          ProductEditViewModel_WithPartials;

public class ProductEditViewModel
{
    public ButtonBarViewModel Buttons { get; set; }
    public LoginPartialViewModel Login { get; set; }
    public ProductViewModel Product { get; set; }
    public bool IsNew { get; set; }
    public bool CanDelete { get; set; }
}