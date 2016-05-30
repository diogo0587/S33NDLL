using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class RouteStretch : Entity<long>
    {
        public virtual int Seq { get; set; }
        public virtual double EstimateMeter { get; set; }
        public virtual int EstimateTime { get; set; }
        public virtual int EstimateTimeAttendance { get; set; }
        public virtual double RouteMeter { get; set; }
        public virtual int RouteTime { get; set; }
        public virtual int TimeAttendance { get; set; }
        public virtual string PolyTrack { get; set; }
        public virtual bool Completed { get; set; }
        public virtual Route Route { get; set; }
        public virtual IEnumerable<RouteDetail> RouteDetails { get; set; }
        public virtual IEnumerable<DashboardEvent> DashboardEvents { get; set; }
    }
}
