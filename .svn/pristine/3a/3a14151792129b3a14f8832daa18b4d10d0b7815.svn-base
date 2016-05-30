using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class ServiceTypeOrderServiceType : Entity<long>
    {
        public virtual OrderServiceType OrderServiceType { get; set; }
        public virtual string Reference { get; set; }
        public virtual IEnumerable<ServiceEvent> ServiceEvents { get; set; }
        public virtual IEnumerable<ServiceLayoutHeader> ServiceLayoutHeaders { get; set; }
    }
}
