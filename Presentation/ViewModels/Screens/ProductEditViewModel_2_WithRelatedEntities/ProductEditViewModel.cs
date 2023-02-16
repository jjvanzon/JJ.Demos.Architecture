namespace JJ.Demos.Architecture.Presentation.ViewModels.Screens.
          ProductEditViewModel_2_WithRelatedEntities;

/// <summary>
/// An Edit ViewModel using several Entity ViewModels.
/// </summary>
public class ProductEditViewModel
{
    public int ID { get; set; }
    public string Name { get; set; }

    // Using Entity ViewModels
    public CategoryViewModel Category { get; set; }
    public ProductTypeViewModel ProductType { get; set; }
}
