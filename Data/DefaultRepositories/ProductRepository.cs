using JetBrains.Annotations;

namespace JJ.Demos.Architecture.Data.DefaultRepositories;

[UsedImplicitly]
public class ProductRepository : RepositoryBase<Product, int>
{
    public ProductRepository(IContext context) : base(context) { }
}
