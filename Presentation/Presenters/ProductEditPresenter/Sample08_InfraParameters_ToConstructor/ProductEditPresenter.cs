namespace JJ.Demos.Architecture.Presentation.Presenters.ProductEditPresenter.Sample08_InfraParameters_ToConstructor;

class ProductEditPresenter
{
    /// <summary>
    /// Passing infra-related parameters to the constructor.
    /// </summary>
    public ProductEditPresenter(
        IRepository repository,
        IAuthenticator authenticator,
        string cultureName)
    {
        // ...
    }
}
