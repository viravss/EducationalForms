using System.Linq.Expressions;
using Infrastructure.Context;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Implementation;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly EducationalFormsContext _context;
    public GenericRepository(EducationalFormsContext context)
    {
        _context = context;
    }

    public async Task<T> GetAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public IQueryable<T> GetAll()
    {
        return _context.Set<T>().AsNoTracking();
    }
    public IQueryable<T> Where(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression);
    }

    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
    }

    public T Update(T entity)
    {
        _context.Set<T>().Update(entity);
        return entity;
    }
    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }


}