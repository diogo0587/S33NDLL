using System;

namespace SeenTechnology.Domain.Entities
{
    public class OrderServiceStatus : Entity<long>
    {
        public virtual OrderService OrderService { get; set; }
        public virtual DateTime? DateReceiving { get; set; }
        public virtual DateTime? DateSynchronization { get; set; }
        public virtual DateTime? DateOut { get; set; }
        public virtual RecordStatus RecordStatus { get; set; }
        public virtual RouteDetail RouteDetail { get; set; }
        public virtual OrderServiceAttendance OrderServiceAttendance { get; set; }
    }
}
