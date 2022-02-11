using System.Linq.Expressions;
using Application.Repositories;
using Application.Services;
using Domain.Models.BaseModel;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Infrastructure.Services.Implementations;

public class GenericService<T> : IGenericService<T> where T : BaseEntity
{
    private readonly IGenericRepository<T> _repository;

    public GenericService(IGenericRepository<T> repository)
    {
        _repository = repository;
    }

    public virtual async Task<T?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }
    public virtual async Task<T?> GetFirst(Expression<Func<T, bool>> expression)
    {
        return await _repository.GetFirst(expression);
    }
    public virtual IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
    {
        return _repository.GetAll(expression);
    }
    public virtual async Task<EntityEntry<T>> Create(T entity)
    {
        return await _repository.Create(entity);
    }
    public virtual EntityEntry<T> Update(T entity)
    {
        return _repository.Update(entity);
    }
    public virtual EntityEntry<T> Delete(T entity)
    {
        return _repository.Delete(entity);
    }
}