namespace JJ.Demos.Architecture.Presentation.ViewModels.Items.
          ProductViewModel_Step4_WithEntity;

/// <summary>
/// This ViewModel references an Entity, which is not recommended.
/// </summary>
public class ProductViewModel
{
    public int ID { get; set; }
    public string Name { get; set; }

    // Not recommended: Referencing an Entity from a ViewModel.
    public Category Category { get; set; }
}
