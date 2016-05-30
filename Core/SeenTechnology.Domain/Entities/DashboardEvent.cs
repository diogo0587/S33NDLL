using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class DashboardEvent : Entity<long>
    {
        public virtual bool? Enable { get; set; }
        [StringLength(200)]
        public virtual string Message { get; set; }
        public virtual double Latitude { get; set; }
        public virtual double Longitude { get; set; }
        [StringLength(1024)]
        public virtual string DashePolytrack { get; set; }
        [StringLength(500)]
        public virtual string Response { get; set; }
        public virtual DateTime? Timestamp { get; set; }
        public virtual DateTime? ResponseDate { get; set; }
        public virtual OrderService OrderService { get; set; }
        public virtual Technician Technician { get; set; }
        public virtual DashboardEventType DashboardEventType { get; set; }
        public virtual RouteStretch RouteStretch { get; set; }
        public virtual Route Route { get; set; }
        public virtual RecordStatus RecordStatuses { get; set; }
        public virtual Account Account { get; set; }
        public virtual Images Images0 { get; set; }
        public virtual Images Images1 { get; set; }

        #region HasMany
        public virtual IEnumerable<DashPerformanceIndicatorAnalytic> DashPerformanceIndicatorAnalytics { get; set; }
        #endregion

        public DashboardEvent() { }
    }
}
