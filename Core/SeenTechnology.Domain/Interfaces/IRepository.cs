﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace SeenTechnology.Domain.Interfaces
{
    public interface IRepository : IDisposable
    {
        void Insert<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        IQueryable<T> NoTrackingQuery<T>() where T : class;
        IQueryable<T> NoTrackingQuery<T>(Expression<Func<T, bool>> predicate) where T : class;
        IQueryable<T> Query<T>() where T : class;
        IQueryable<T> Query<T>(Expression<Func<T, bool>> predicate) where T : class;
    }
}
