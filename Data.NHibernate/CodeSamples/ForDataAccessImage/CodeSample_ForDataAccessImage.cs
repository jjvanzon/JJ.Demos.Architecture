namespace JJ.Demos.Architecture.Data.NHibernate.CodeSamples.ForDataAccessImage;

class Customer
{
    public virtual int ID { get; set; }
    public virtual string Name { get; set; }
}
class Mapping : ClassMap<Customer>
{
    Mapping()
    {
        Id(x => x.ID);
        Map(x => x.Name);
    }
}
interface IRepository
{
    Customer GetByName(string name);
}
partial class Repository : IRepository
{
    public Customer GetByName(string name)
        => _context.Session
                   .QueryOver<Customer>()
                   .Where(x => x.Name == name)
                   .SingleOrDefault();
}