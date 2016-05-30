using System;

namespace SeenTechnology.Domain.Entities
{
    public class ScanAuditingDetailTracking : Entity<long>
    {
        public virtual RecordStatus RecordStatus { get; set; }
        public virtual ScanAuditingDetail ScanAuditingDetail { get; set; }
        public virtual Alternative Alternative { get; set; }
        public virtual Images Images { get; set; }
        public virtual Account Account { get; set; }
        public virtual string Description { get; set; }
    }
}
