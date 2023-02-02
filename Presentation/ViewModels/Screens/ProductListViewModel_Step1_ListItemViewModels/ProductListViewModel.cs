namespace JJ.Demos.Architecture.Presentation.ViewModels.Screens.
          ProductListViewModel_Step1_ListItemViewModels;

/// <summary>
/// Example of a List ViewModel that uses ListItem ViewModels.
/// </summary>
public class ProductListViewModel
{
    public ButtonBarViewModel Buttons { get; set; }
    public PagerViewModel Pager { get; set; }

    // Here, Product ListItemViewModel is used.
    public IList<ProductListItemViewModel> Products { get; set; }
}
