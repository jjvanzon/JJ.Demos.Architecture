using JJ.Framework.Data.NHibernate;

namespace JJ.Demos.Architecture.Data.NHibernate.CodeSamples.ForDataAccessImage;

class Customer
{
    public virtual int ID { get; set; }
    public virtual string Name { get; set; }
}

class CustomerMapping : ClassMap<Customer>
{
    public CustomerMapping()
    {
        Id(x => x.ID);
        Map(x => x.Name);
    }
}

interface ICustomerRepository : IRepository<Customer, int>
{
    Customer GetByName(string name);
}

class CustomerRepository : RepositoryBase<Customer, int>, ICustomerRepository
{
    public Customer GetByName(string name)
        => _context.Session.QueryOver<Customer>()
                   .Where(x => x.Name == name)
                   .SingleOrDefault();

    public CustomerRepository(IContext context)
        : base(context) { }
}