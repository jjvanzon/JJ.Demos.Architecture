namespace JJ.Demos.Architecture.Presentation.ViewModels.Screens.
          ScreenViewModelBase_2_Clean;

public abstract class ScreenViewModelBase
{
    public bool Visible { get; set; }
    public bool Successful { get; set; }
    public IList<string> ValidationMessages { get; set; }
}
