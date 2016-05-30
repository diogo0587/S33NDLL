using System;

namespace SeenTechnology.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool IsNoTracking { get; }
        bool HasTransaction { get; }
        object Session { get; }
        object NoTrackingSession { get; }
        IRepository GetRepository();
        void BeginTransaction(bool isNoTracking = false);
        void RollbackTransaction();
        void Commit();
    }
}
