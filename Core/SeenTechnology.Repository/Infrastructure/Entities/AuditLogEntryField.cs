using SeenTechnology.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeenTechnology.Repository.Infrastructure.Entities
{
    public class AuditLogEntryField : Entity<long>
    {
        public virtual string FieldName { get; set; }
        public virtual string OldValue { get; set; }
        public virtual string NewValue { get; set; }
        public virtual bool HasChanges { get; set; }
        public virtual AuditLogEntry AuditLogEntry { get; set; }
    }
}
