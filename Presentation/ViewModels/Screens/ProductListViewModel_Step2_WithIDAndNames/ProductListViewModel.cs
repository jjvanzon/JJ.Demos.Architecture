namespace JJ.Demos.Architecture.Presentation.ViewModels.Screens.
          ProductListViewModel_Step2_WithIDAndNames;

/// <summary>
/// Example of a List ViewModel that uses IDAndName as the item type.
/// </summary>
public class ProductListViewModel
{
    // Here, IDAndName is used as a list item.
    public IList<IDAndName> Products { get; set; }
}
