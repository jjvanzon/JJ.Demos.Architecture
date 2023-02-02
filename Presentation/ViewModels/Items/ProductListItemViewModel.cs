namespace JJ.Demos.Architecture.Presentation.ViewModels.Items;

public class ProductListItemViewModel
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string UsedBy { get; set; }
    public bool CanDelete { get; set; }
}
