using System.Linq.Expressions;
using Domain.Models.BaseModel;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Application.Services;

public interface IGenericService<T> where T : BaseEntity
{
    Task<T?> GetByIdAsync(int id);
    Task<T?> GetFirst(Expression<Func<T, bool>> expression);
    IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
    Task<EntityEntry<T>> Create(T entity);
    EntityEntry<T> Update(T entity);
    EntityEntry<T> Delete(T entity);
}