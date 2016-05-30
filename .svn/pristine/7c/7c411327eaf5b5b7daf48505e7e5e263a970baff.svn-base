using NHibernate;
using SeenTechnology.Domain.Interfaces;
using System;

namespace SeenTechnology.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public bool IsNoTracking { get; private set; }
        public bool HasTransaction { get; private set; }
        public object Session { get; private set; }
        public object NoTrackingSession { get; private set; }

        private ITransaction Transaction;
        public UnitOfWork(ISession session, IStatelessSession noTrackingSession)
        {
            Session = session;
            NoTrackingSession = noTrackingSession;
        }

        public IRepository GetRepository()
        {
            return new Repository(this);
        }

        public void BeginTransaction(bool isNoTracking = false)
        {
            IsNoTracking = isNoTracking;
            HasTransaction = true;

            Transaction = (IsNoTracking)
                ? ((IStatelessSession)NoTrackingSession).BeginTransaction()
                : ((ISession)Session).BeginTransaction();
        }
        public void Commit()
        {
            try
            {
                if (Equals(Transaction, null) && !HasTransaction)
                {
                    throw new Exception("A transação não foi iniciada");
                }

                Transaction.Commit();
            }
            catch (Exception ex)
            {
                throw new Exception("Um erro ocorreu durante o processo de commit.", ex);
            }
        }

        public void RollbackTransaction()
        {
            if (Equals(Transaction, null) && !HasTransaction)
            {
                throw new Exception("A transação não foi iniciada");
            }

            Transaction.Rollback();
        }        

        #region Dispose methods
        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~UnitOfWork()
        {
            Dispose(false);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (!disposed)
            {
                if (!Equals(Session, null))
                {
                    ((ISession)Session).Clear();
                    ((ISession)Session).Close();
                    ((ISession)Session).Dispose();
                    Session = null;
                }

                if (!Equals(NoTrackingSession, null))
                {
                    ((IStatelessSession)NoTrackingSession).Close();
                    ((IStatelessSession)NoTrackingSession).Dispose();
                    NoTrackingSession = null;
                }

                if (!Equals(Transaction, null))
                {
                    Transaction.Dispose();
                    Transaction = null;
                }

                disposed = true;
            }
        }
        #endregion
    }
}
