using System;
using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class ScanAuditingDetail : Entity<long>
    {
        public virtual RecordStatus RecordStatus { get; set; }
        public virtual ScanAuditing ScanAndAudinting { get; set; }
        public virtual Alternative Alternative { get; set; }
        public virtual Images Images { get; set; }
        public virtual Account Account { get; set; }
        public virtual DateTime? LastUpdate { get; set; }
        public virtual string Description { get; set; }
        public virtual IEnumerable<ScanAuditingDetailTracking> ScanAuditingDetailTrackings { get; set; }
    }
}
