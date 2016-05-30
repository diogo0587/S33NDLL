namespace SeenTechnology.Domain.Entities
{
    public class OrderServiceTracking : Entity<long>
    {
        public virtual OrderService OrderService { get; set; }
        public virtual RecordStatus RecordStatus { get; set; }
        public virtual Account Account { get; set; }
        public virtual string Reason { get; set; }
        public virtual RouteDetail RouteDetail { get; set; }
        public virtual OrderServiceAttendance OrderServiceAttendance { get; set; }
    }
}
