namespace JJ.Demos.Architecture.Presentation.ViewModels.Screens.
          ProductEditViewModel_Step2_WithRelatedEntities;

/// <summary>
/// An Edit ViewModel using several Entity ViewModels.
/// </summary>
public class ProductEditViewModel
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool CanDelete { get; set; }
    public IList<string> ValidationMessages { get; set; }

    // Uses Entity ViewModels
    public CategoryViewModel Category { get; set; }
    public ProductTypeViewModel ProductType { get; set; }
}
