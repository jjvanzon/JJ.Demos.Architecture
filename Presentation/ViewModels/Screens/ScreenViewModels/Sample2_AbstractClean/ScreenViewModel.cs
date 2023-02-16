namespace JJ.Demos.Architecture.Presentation.ViewModels.Screens.ScreenViewModels.Sample2_AbstractClean;

public abstract class ScreenViewModel
{
    public bool Visible { get; set; }
    public bool Successful { get; set; }
    public IList<string> ValidationMessages { get; set; }
}
