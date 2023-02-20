using JJ.Demos.Architecture.Presentation.ViewModels.Items.ProductViewModels.Sample6_RealisticExample;
using JJ.Demos.Architecture.Presentation.ViewModels.Screens.ProductEditViewModels.Sample9_RealisticExample;

namespace JJ.Demos.Architecture.Presentation.ToViewModel;

internal static class ToViewModelExtensions
{
    public static ProductEditViewModel ToEditViewModel(this Product entity)
    {
        var viewModel = new ProductEditViewModel
        {
            Buttons = new ButtonBarViewModel(),
            Validation = new ValidationViewModel(),
            CategoryLookup = new List<IDAndName>(),
            ProductTypeLookup = new List<IDAndName>(),
            Login = new LoginPartialViewModel(),
            Product = entity.ToViewModel()
        };
        return viewModel;
    }

    public static ProductViewModel ToViewModel(this Product entity)
    {
        var viewModel = new ProductViewModel
        {
            ID = entity.ID,
            ProductNumber = entity.ProductNumber,
            Name = entity.Name,
            Description = entity.Description,
            Price = entity.PriceWithoutVat,
            ProductType = entity.ProductType?.ToIDAndName(),
            Category = entity.Category?.ToIDAndName()
        };
        return viewModel;
    }

    public static IDAndName ToIDAndName(this ProductType entity)
    {
        var idAndName = new IDAndName
        {
            ID = entity.ID,
            Name = entity.Name
        };
        return idAndName;
    }

    public static IDAndName ToIDAndName(this Category entity)
    {
        var idAndName = new IDAndName
        {
            ID = entity.ID,
            Name = entity.Name
        };
        return idAndName;
    }
}
