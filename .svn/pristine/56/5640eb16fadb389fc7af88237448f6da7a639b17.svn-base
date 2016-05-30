using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class ScanAuditing : Entity<long>
    {
        public virtual RecordStatus RecordStatus { get; set; }
        public virtual OrderService OrderService { get; set; }
        public virtual string TrackingNumber { get; set; }
        public virtual IEnumerable<ScanAuditingDetail> ScanAuditingDetails { get; set; }
    }
}
