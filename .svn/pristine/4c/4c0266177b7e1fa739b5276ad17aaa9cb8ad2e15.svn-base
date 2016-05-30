using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class OrderServiceAttendance : Entity<long>
    {
        public virtual OrderService OrderService { get; set; }
        public virtual ServiceEvent ServiceEvent { get; set; }
        public virtual RouteDetail RouteDetail { get; set; }
        public virtual DateTime? DateTimeStart { get; set; }
        public virtual DateTime? DateTimeCompleted { get; set; }
        public virtual Technician Technician { get; set; }
        public virtual float? Latitude { get; set; }
        public virtual float? Longitude { get; set; }
        [StringLength(150)]
        public virtual string Key { get; set; }

        #region HasMany
        public virtual IEnumerable<OrderServiceStatus> OrderServiceStatuses { get; set; }
        public virtual IEnumerable<OrderServiceTracking> OrderServiceTrackings { get; set; }
        public virtual IEnumerable<OrderServiceWorkflow> OrderServiceWorkflows { get; set; }
        public virtual IEnumerable<RouteDetail> RouteDetails { get; set; }
        public virtual IEnumerable<SendWorkflowToCustomer> SendWorkflowToCustomers { get; set; }
        #endregion


        public OrderServiceAttendance() { }
    }
}
