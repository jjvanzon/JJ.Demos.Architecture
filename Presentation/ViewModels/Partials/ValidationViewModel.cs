namespace JJ.Demos.Architecture.Presentation.ViewModels.Partials;

public class ValidationViewModel
{
    public bool Successful { get; set; }
    public IList<string> ValidationMessages { get; set; }
}
