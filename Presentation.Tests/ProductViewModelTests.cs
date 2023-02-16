using JJ.Demos.Architecture.Presentation.ViewModels.Items.ProductViewModels.Sample4_WithEntity;

namespace JJ.Demos.Architecture.Presentation.Tests
{
    public class ProductViewModelTests
    {
        /// <summary>
        /// Linking a ViewModel to an Entity 
        /// can result in the availability of other related Entities, 
        /// broadening the scope of the view beyond our intentions.
        /// </summary>
        [Fact]
        public void Test_ProductViewModel_WithEntity()
        {
            var productViewModel = CreateProductViewModel();

            // Unintentionally, many customers' data
            // is available in the Product view, 
            // because we referenced an Entity.
            var customers =
                productViewModel.Category.Products
                                .SelectMany(x => x.Orders)
                                .Select(x => x.Customer);
        }

        private ProductViewModel CreateProductViewModel() =>
            new()
            {
                Category = new Category()
            };

    }
}