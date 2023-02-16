namespace JJ.Demos.Architecture.Presentation.ViewModels.Screens.
          ProductEditViewModel_4_WithLookup;

/// <summary>
/// Edit ViewModel with a Lookup List in it.
/// </summary>
public class ProductEditViewModel
{
    public int ID { get; set; }
    public string Name { get; set; }
    public IDAndName ProductType { get; set; }

    // Here is the Lookup ViewModel.
    IList<IDAndName> ProductTypeLookup { get; set; }
}