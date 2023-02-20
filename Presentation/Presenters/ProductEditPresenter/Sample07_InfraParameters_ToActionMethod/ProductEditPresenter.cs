// Pseudo-code: excluded from compilation

using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductEditViewModels.Sample9_RealisticExample;

namespace JJ.Demos.Architecture.Presentation.Presenters.ProductEditPresenter.Sample07_InfraParameters_ToActionMethod;

class ProductEditPresenter
{
    object Save(
        ProductEditViewModel userInput,
        IAuthenticator authenticator) // Infra-related parameter
    {
        // ...
    }
}

