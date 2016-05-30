using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class Images : Entity<long>
    {
        [StringLength(255)]
        public virtual string FileName { get; set; }
        [StringLength(255)]
        public virtual string VirtualFileName { get; set; }
        public virtual double Latitude { get; set; }
        public virtual double Longitude { get; set; }
        public virtual DateTime? Timestamp { get; set; }
        public virtual string Spin { get; set; }
        public virtual Account Account { get; set; }
        public virtual Technician Technician { get; set; }
        public virtual ImageType ImageType { get; set; }
        public virtual OrderService OrderService { get; set; }

        #region HasMany
        public virtual IEnumerable<DashboardEvent> Dashboardevents { get; set; }
        public virtual IEnumerable<ScanAuditingDetail> ScanAuditingDetails { get; set; }
        public virtual IEnumerable<ScanAuditingDetailTracking> ScanAuditingDetailTrackings { get; set; }
        #endregion

        public Images() { }

    }
}
