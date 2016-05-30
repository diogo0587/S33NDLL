using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class Technician : Entity<long>
    {
        public virtual string Name { get; set; }
        public virtual bool Enable { get; set; }
        [StringLength(10)]
        public virtual string ExternalId { get; set; }
        public virtual Account Account { get; set; }
        [Required]
        public virtual string CPF { get; set; }
        public virtual IEnumerable<BiorecycleTemplate> BiorecycleTemplates { get; set; }
        public virtual IEnumerable<DashboardEvent> DashboardEvents { get; set; }
        public virtual IEnumerable<DeviceAllocated> DeviceAllocateds { get; set; }
        public virtual IEnumerable<GpsPosition> GpsPositions { get; set; }
        public virtual IEnumerable<Images> Images { get; set; }
        public virtual IEnumerable<OrderServiceAttendance> OrderServiceAttendances { get; set; }
        public virtual IEnumerable<OrderServiceWorkflowQuestionResponse> OrderServiceWorkflowQuestionResponses { get; set; }
        public virtual IEnumerable<Route> Routes { get; set; }
    }
}
