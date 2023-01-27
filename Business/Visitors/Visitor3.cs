using JJ.Demos.Architecture.Data.Entities;

namespace JJ.Demos.Architecture.Business.Visitors;

class Visitor3
{
    void VisitProduct(Product product) { }
    void VisitPhysicalProduct(Product product) { }
    void VisitDigitalProduct(Product product) { }
}
