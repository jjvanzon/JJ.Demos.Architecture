namespace JJ.Demos.Architecture.Presentation.ViewModels.Items.
          ProductViewModel_Step2_Composite;

public class ProductViewModel
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ProductTypeViewModel ProductType { get; set; }
    public CategoryViewModel Category { get; set; }
}
