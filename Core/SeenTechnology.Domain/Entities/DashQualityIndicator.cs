using System;

namespace SeenTechnology.Domain.Entities
{
    public class DashQualityIndicator : Entity<long>
    {
        public virtual double TimeAttendanceConfig { get; set; }
        public virtual double TimeAttendanceReal { get; set; }
        public virtual double AmountOsFinished { get; set; }
        public virtual double AmountIdeal { get; set; }
        public virtual double AmountReal { get; set; }
        public virtual DateTime Timestamp { get; set; }
        public virtual OrderServiceType OrderServiceType { get; set; }
        public virtual Operation Operation { get; set; }
    }
}
