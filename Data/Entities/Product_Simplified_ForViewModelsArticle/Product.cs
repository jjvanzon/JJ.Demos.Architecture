namespace JJ.Demos.Architecture.Data.Entities.Product_Simplified_ForViewModelsArticle;

public class Product
{
    public virtual int ID { get; set; }
    public virtual string Name { get; set; }
    public virtual Category Category { get; set; }
}