using JJ.Demos.Architecture.Data.Entities;
using JJ.Framework.Data;

namespace JJ.Demos.Architecture.Data.RepositoryInterfaces
{
    public interface IProductRepository
        : IRepository<Product, int> 
    { }
}
