namespace JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductEditViewModels.Sample1_SimpleTypes;

public class ProductEditViewModel
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string ProductType { get; set; }
    public IList<string> ValidationMessages { get; set; }
    public bool CanDelete { get; set; }
}