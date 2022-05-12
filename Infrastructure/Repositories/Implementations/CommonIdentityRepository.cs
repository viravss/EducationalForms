using System.Linq.Expressions;
using Application.Repositories;
using Domain.Models.BaseModel;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Infrastructure.Repositories.Implementations;

public class CommonIdentityRepository<T> : ICommonIdentityRepository<T> where T : IdentityBaseEntity
{
    private readonly EducationalFormsContext _context;
    public CommonIdentityRepository(EducationalFormsContext context)
    {
        _context = context;
    }
    public virtual async Task<T?> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }
    public virtual async Task<T?> GetFirst(Expression<Func<T, bool>> expression)
    {
        return await _context.Set<T>().FirstOrDefaultAsync(expression);
    }
    public virtual IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression);
    }
    public virtual async Task<EntityEntry<T>> Create(T entity)
    {
        return await _context.Set<T>().AddAsync(entity);
    }
    public virtual EntityEntry<T> Update(T entity)
    {
        return _context.Set<T>().Update(entity);
    }
    public virtual EntityEntry<T> Delete(T entity)
    {
        return _context.Set<T>().Remove(entity);
    }
}