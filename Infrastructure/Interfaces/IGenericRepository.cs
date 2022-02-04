using System.Linq.Expressions;

namespace Infrastructure.Interfaces;

public interface IGenericRepository<T>
{
    public Task<T> GetAsync(int id);
    public IQueryable<T> GetAll();
    public IQueryable<T> Where(Expression<Func<T, bool>> expression);
    public Task AddAsync(T entity);
    public T Update(T entity);
    public void Delete(T entity);
}