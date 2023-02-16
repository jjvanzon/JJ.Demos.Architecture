namespace JJ.Demos.Architecture.Presentation.ViewModels.Screens.
          ProductEditViewModel_3_WithPartials;

/// <summary>
/// Edit ViewModel with Partials
/// </summary>
public class ProductEditViewModel
{
    public int ID { get; set; }
    public string Name { get; set; }

    // Partials:
    public ButtonBarViewModel Buttons { get; set; }
    public LoginPartialViewModel Login { get; set; }
}