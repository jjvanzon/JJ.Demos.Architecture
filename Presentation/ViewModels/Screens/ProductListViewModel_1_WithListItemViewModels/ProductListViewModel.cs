namespace JJ.Demos.Architecture.Presentation.ViewModels.Screens.
          ProductListViewModel_1_WithListItemViewModels;

/// <summary>
/// Example of a ViewModel using ListItem ViewModels.
/// </summary>
public class ProductListViewModel
{
    // Here, a ListItem ViewModel is used.
    public IList<ProductItemViewModel> Products { get; set; }
}
