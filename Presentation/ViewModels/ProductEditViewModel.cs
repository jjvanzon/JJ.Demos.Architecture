namespace JJ.Demos.Architecture.Presentation.ViewModels;

public class ProductEditViewModel 
{
    public ButtonBarViewModel Buttons { get; set; }
    public LoginPartialViewModel Login { get; set; }
    public ProductViewModel Product { get; set; }
    public bool IsNew { get; set; }
    public bool CanDelete { get; set; }
}