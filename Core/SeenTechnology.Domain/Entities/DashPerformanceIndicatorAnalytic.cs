using System;

namespace SeenTechnology.Domain.Entities
{
    public class DashPerformanceIndicatorAnalytic : Entity<long>
    {
        public virtual DateTime TimeStamp { get; set; }
        public virtual DashboardEvent DashboardEvent { get; set; }
    }
}
