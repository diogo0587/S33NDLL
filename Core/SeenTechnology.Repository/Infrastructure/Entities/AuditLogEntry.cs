using NHibernate;
using SeenTechnology.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SeenTechnology.Repository.Infrastructure.Entities
{
    public class AuditLogEntry : Entity<long>
    {
        public virtual int DbSessionId { get; protected set; }
        public virtual int DbTransactionId { get; protected set; }
        public virtual string UserSession { get; set; }
        public virtual long UserId { get; set; }
        public virtual string UserName { get; set; }
        public virtual string AuditEntryType { get; protected set; }
        public virtual long EntityId { get; protected set; }
        public virtual string EntityFullName { get; protected set; }
        public virtual string EntityShortName { get; protected set; }
        public virtual DateTime CreationDate { get; protected set; }
        public virtual IList<AuditLogEntryField> AuditLogEntryFields { get; set; }

        public delegate void InitAuditLogEntryHandler(AuditLogEntry sender);
        public static event InitAuditLogEntryHandler InitAuditLogEntry;

        #region Constructors
        public AuditLogEntry() { }
        public virtual AuditLogEntry CreateAuditLogEntry(ISession session, object entity, string auditEntryType)
        {
            AuditLogEntryFields = new List<AuditLogEntryField>();
            EntityShortName = entity.GetType().Name;
            EntityFullName = entity.GetType().FullName;
            EntityId = Convert.ToInt64(entity.GetType().GetProperty("Id").GetValue(entity));
            AuditEntryType = auditEntryType;
            CreationDate = DateTime.Now;
            DbSessionId = session.GetHashCode();
            DbTransactionId = session.Transaction.GetHashCode();
            InitAuditLogEntry(this);

            return this;
        }
        #endregion
    }
}
