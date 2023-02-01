// ReSharper disable CheckNamespace

namespace JJ.Demos.Architecture.Presentation.ViewModels.
          ProductEditViewModel_Simple;

public class ProductEditViewModel
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool CanDelete { get; set; }
    public string Category { get; set; }
    public string ProductType { get; set; }
    public IList<string> ValidationMessages { get; set; }
}