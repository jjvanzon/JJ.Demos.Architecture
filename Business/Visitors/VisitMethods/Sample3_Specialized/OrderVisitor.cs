namespace JJ.Demos.Architecture.Business.Visitors.VisitMethods.Sample3_Specialized;

class OrderVisitor
{
    void VisitPhysicalProduct(Product product) { }
    void VisitDigitalProduct(Product product) { }
}
