using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class StartPointOperation : Entity<long>
    {
        public virtual StartPoint StartPoint { get; set; }
        public virtual Operation Operation { get; set; }

        public virtual IEnumerable<AccountStartPointOperation> AccountStartPointOperations { get; set; }
        public virtual IEnumerable<OrderService> OrderServices { get; set; }
        public virtual IEnumerable<OrderServiceScheduleParameter> OrderServiceScheduleParameters { get; set; }
        public virtual IEnumerable<Route> Routes { get; set; }
        public virtual IEnumerable<ZipCodeRangeStartPointOperation> ZipCodeRangeStartPointOperations { get; set; }
    }
}
