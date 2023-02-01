namespace JJ.Demos.Architecture.Presentation.ViewModels.Partials;

public class LoginPartialViewModel 
{
    public bool CanLogIn { get; set; }
    public bool CanLogOut { get; set; }
    public bool UserNameVisible { get; set; }
    public bool PasswordVisible { get; set; }
    public string UserDisplayName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}
