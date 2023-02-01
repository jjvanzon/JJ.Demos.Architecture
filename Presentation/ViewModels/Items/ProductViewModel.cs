namespace JJ.Demos.Architecture.Presentation.ViewModels.Items;

public class ProductViewModel 
{ 
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    ProductTypeViewModel ProductType { get; set; }
    CategoryViewModel Category { get; set; }
}
