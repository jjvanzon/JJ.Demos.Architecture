namespace JJ.Demos.Architecture.Presentation.ViewModels.Screens.CategoryListViewModels.Sample1_WithListItemViewModels;

/// <summary>
/// Example of a ViewModel using ListItem ViewModels.
/// </summary>
public class CategoryListViewModel
{
    // Here, a ListItem ViewModel is used.
    public IList<CategoryItemViewModel> Categories { get; set; }
}
