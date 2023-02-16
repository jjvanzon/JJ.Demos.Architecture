namespace JJ.Demos.Architecture.Presentation.ViewModels.Items.
          ProductViewModel_6_RealisticExample;

public class ProductViewModel 
{ 
    public int ID { get; set; }
    public string ProductNumber { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public IDAndName ProductType { get; set; }
    public IDAndName Category { get; set; }
}
