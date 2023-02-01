namespace JJ.Demos.Architecture.Presentation.ViewModels.Partials;

/// <summary>
/// PartialViewModel representing a ButtonBar.
/// </summary>
public class ButtonBarViewModel 
{ 
    public bool CanSave { get; set; }
    public bool CanDelete { get; set; }
    public bool CanCreate { get; set; }
    public bool CanShowList { get; set; }
    public bool CanGoBack { get; set; }
}
