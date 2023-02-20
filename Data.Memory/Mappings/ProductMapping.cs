using JetBrains.Annotations;

namespace JJ.Demos.Architecture.Data.Memory.Mappings;

[UsedImplicitly]
public class ProductMapping : MemoryMapping<Product>
{
    public ProductMapping()
    {
        IdentityPropertyName = "ID";
        IdentityType = IdentityType.Assigned;
    }
}
