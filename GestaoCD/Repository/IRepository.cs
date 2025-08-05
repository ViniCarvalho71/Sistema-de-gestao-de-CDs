namespace GestaoCD.Repository;

public interface IRepository
{
    void Add(object model);
    void Save(object model);
    void Exclude(object model);
    T GetById<T>(long id);
    IQueryable<T> Get<T>();
    
    IDisposable StartTransaction();
    void Commit();
    void Rollback();
}