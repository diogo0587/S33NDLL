using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class Route : Entity<long>
    {
        public virtual Technician Technician { get; set; }
        public virtual MobileDevice MobileDevice { get; set; }
        public virtual StartPointOperation StartPointOperation { get; set; }
        public virtual DateTime? Start { get; set; }
        public virtual DateTime? Finished { get; set; }
        public virtual DateTime? Received { get; set; }
        [StringLength(40)]
        public virtual string SessionClusterize { get; set; }
        [StringLength(200)]
        public virtual string Auxiliary1 { get; set; }
        [StringLength(200)]
        public virtual string Auxiliary2 { get; set; }
        [StringLength(200)]
        public virtual string Auxiliary3 { get; set; }
        [StringLength(200)]
        public virtual string Auxiliary4 { get; set; }
        [StringLength(200)]
        public virtual string Auxiliary5 { get; set; }
        public virtual bool Enable { get; set; }
        public virtual RecordStatus RecordStatus { get; set; }

        #region HasMany
        public virtual IEnumerable<RouteProduct> RouteProducts { get; set; }
        public virtual IEnumerable<RouteComponent> RouteComponents { get; set; }
        public virtual IEnumerable<RouteStretch> RouteStretches { get; set; }
        public virtual IEnumerable<RouteDelivery> RouteDeliveries { get; set; }
        public virtual IEnumerable<DashboardEvent> DashboardEvents { get; set; }
        public virtual IEnumerable<RequestTrackingDetail> RequestTrackingDetail { get; set; }
        #endregion

        public Route() { }
    }
}
