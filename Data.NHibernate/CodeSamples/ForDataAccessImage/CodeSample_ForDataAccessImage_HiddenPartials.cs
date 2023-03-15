namespace JJ.Demos.Architecture.Data.NHibernate.CodeSamples.ForDataAccessImage;

partial class Repository
{
    NHibernateContext _context;

    public Repository(IContext context)
        => _context = (NHibernateContext)context;
}
