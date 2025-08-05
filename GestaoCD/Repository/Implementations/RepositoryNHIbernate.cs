using NHibernate;
using ISession = NHibernate.ISession;

namespace GestaoCD.Repository.Implementations;

public class RepositoryNHIbernate : IRepository
{
    
    private readonly ISessionFactory sessionFactory;
    private readonly ISession session;

    public RepositoryNHIbernate(ISessionFactory sessionFactory)
    {
        this.sessionFactory = sessionFactory;
        this.session = sessionFactory.OpenSession();
    }
    
    public void Add(object model)
    {
        session.Save(model);
    }

    public void Save(object model)
    {
        session.Merge(model);
    }

    public void Exclude(object model)
    {
        session.Delete(model);
    }

    public T GetById<T>(long id)
    {
        return session.Get<T>(id);
    }

    public IQueryable<T> Get<T>()
    {
        return session.Query<T>();
    }

    public IDisposable StartTransaction()
    {
        var transaction = session.BeginTransaction();
        return transaction;
    }

    public void Commit()
    {
        session.GetCurrentTransaction().Commit();
    }

    public void Rollback()
    {
        session.GetCurrentTransaction()?.Rollback();
    }
}