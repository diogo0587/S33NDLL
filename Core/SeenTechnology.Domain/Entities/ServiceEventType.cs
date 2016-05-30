using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class ServiceEventType : Entity<long>
    {
        public virtual string Description { get; set; }
        public virtual IEnumerable<ServiceEvent> ServiceEvents { get; set; }
    }
}
