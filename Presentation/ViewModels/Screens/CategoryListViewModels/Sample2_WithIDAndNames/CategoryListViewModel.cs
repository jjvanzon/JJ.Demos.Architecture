namespace JJ.Demos.Architecture.Presentation.ViewModels.Screens.CategoryListViewModels.Sample2_WithIDAndNames;

/// <summary>
/// Example of a List ViewModel that uses IDAndName as the item type.
/// </summary>
public class CategoryListViewModel
{
    // Here, IDAndName is used as a list item.
    public IList<IDAndName> Categories { get; set; }
}
