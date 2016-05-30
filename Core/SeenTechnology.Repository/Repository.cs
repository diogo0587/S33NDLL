using SeenTechnology.Domain.Interfaces;
using System;
using NHibernate.Linq;
using System.Linq.Expressions;
using NHibernate;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SeenTechnology.Domain.Util;
using System.Text;

namespace SeenTechnology.Repository
{
    public class Repository : IRepository
    {
        private IUnitOfWork _unitOfWork;

        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Insert<T>(T entity) where T : class
        {
            ValidateEntity(entity);

            if (!_unitOfWork.HasTransaction)
                throw new Exception("A transação não foi iniciada");

            var validator = new List<ValidationResult>();

            ((ISession)_unitOfWork.Session).Save(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            ValidateEntity(entity);

            if (!_unitOfWork.HasTransaction)
                throw new Exception("A transação não foi iniciada");

            if (_unitOfWork.IsNoTracking)
            {
                ((IStatelessSession)_unitOfWork.NoTrackingSession).Update(entity);
            }
            else
            {
                ((ISession)_unitOfWork.Session).Merge(entity);
            }
        }
        public void Delete<T>(T entity) where T : class
        {
            ValidateEntity(entity);

            if (!_unitOfWork.HasTransaction)
                throw new Exception("A transação não foi iniciada");

            if (_unitOfWork.IsNoTracking)
            {
                ((IStatelessSession)_unitOfWork.NoTrackingSession).Delete(entity);
            }
            else
            {
                ((ISession)_unitOfWork.Session).Delete(entity);
            }
        }
        public IQueryable<T> Query<T>() where T : class
        {
            return ((ISession)_unitOfWork.Session).Query<T>();
        }
        public IQueryable<T> Query<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return ((ISession)_unitOfWork.Session).Query<T>().Where(predicate);
        }
        public IQueryable<T> NoTrackingQuery<T>() where T : class
        {
            return ((IStatelessSession)_unitOfWork.NoTrackingSession).Query<T>();
        }
        public IQueryable<T> NoTrackingQuery<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return ((IStatelessSession)_unitOfWork.NoTrackingSession).Query<T>().Where(predicate);
        }
        private void ValidateEntity<T>(T entity) where T : class
        {
            IList<string> errorMessages;

            if (entity.IsValid(out errorMessages))
                return;

            var builder = new StringBuilder();

            foreach (var message in errorMessages)
                builder.AppendLine($"- {message}");

            throw new ArgumentException($"Entidade inválida {Environment.NewLine} {builder.ToString()}");
        }
        #region Dispose methods
        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~Repository()
        {
            Dispose(false);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (!disposed)
            {
                if (!Equals(_unitOfWork, null))
                {
                    _unitOfWork.Dispose();
                    _unitOfWork = null;
                }

                disposed = true;
            }
        }
        #endregion
    }
}
