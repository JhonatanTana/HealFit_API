﻿using HealFit.Context;
using HealFit.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace HealFit.Repositories;
public class Repository<T> : IRepository<T> where T : class {
    protected readonly AppDbContext _context;

    public Repository(AppDbContext context) {
        _context = context;
    }
    public async Task<IEnumerable<T>> GetAllAsync(
        params Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includes) {
        IQueryable<T> query = _context.Set<T>().AsNoTracking();

        // Apply includes if provided
        if (includes != null) {
            foreach (var include in includes) {
                query = include(query);
            }
        }

        return await query.ToListAsync();
    }
    public async Task<IQueryable<T>> GetAllQueryableAsync() {

        return _context.Set<T>().AsNoTracking();
    }
    public async Task<T?> GetAsync(Expression<Func<T, bool>> predicate, params Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includes) {
        IQueryable<T> query = _context.Set<T>();

        foreach (var include in includes) {
            query = include(query);
        }

        return await query.FirstOrDefaultAsync(predicate);
    }
    public T Create(T entity) {

        _context.Set<T>().Add(entity);
        return entity;
    }
    public T Update(T entity) {

        _context.Set<T>().Update(entity);
        return entity;
    }
    public T Delete(T entity) {

        _context.Set<T>().Remove(entity);
        return entity;
    }
}
