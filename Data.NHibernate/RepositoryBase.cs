namespace JJ.Demos.Architecture.Data.NHibernate;

internal class RepositoryBase<TEntity, TID>
    : JJ.Framework.Data.RepositoryBase<TEntity, TID> where TEntity : class, new()
{
    protected new readonly NHibernateContext _context;

    public RepositoryBase(IContext context) : base(context)
        => _context = (NHibernateContext)context;
}
