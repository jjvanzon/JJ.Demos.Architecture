namespace JJ.Demos.Architecture.Business.Visitors.
          VisitMethods3_SpecializedVisitMethods;

class OrderVisitor
{
    void VisitPhysicalProduct(Product product) { }
    void VisitDigitalProduct(Product product) { }
}
