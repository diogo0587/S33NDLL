using System;
using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class RouteDetail : Entity<long>
    {
        public virtual OrderService OrderService { get; set; }
        public virtual bool Enable { get; set; }
        public virtual RecordStatus RecordStatus { get; set; }
        public virtual ServiceEvent ServiceEvent { get; set; }
        public virtual DateTime? LastUpdate { get; set; }
        public virtual DateTime? DatetimeStart { get; set; }
        public virtual DateTime? DatetimeEnd { get; set; }
        public virtual bool IsNext { get; set; }
        public virtual string Reason { get; set; }
        public virtual double Latitude { get; set; }
        public virtual double Longitude { get; set; }
        public virtual OrderServiceAttendance OrderServiceAttendance { get; set; }
        public virtual RouteStretch RouteStretch { get; set; }
        public virtual IEnumerable<NotifyOrderService> NotifyOrderServices { get; set; }
        public virtual IEnumerable<OrderServiceAttendance> OrderServiceAttendances { get; set; }
        public virtual IEnumerable<OrderServiceStatus> OrderServiceStatuses { get; set; }
        public virtual IEnumerable<OrderServiceTracking> OrderServiceTrackings { get; set; }
        public virtual IEnumerable<OrderServiceWorkflow> OrderServiceWorkflows { get; set; }

    }
}
