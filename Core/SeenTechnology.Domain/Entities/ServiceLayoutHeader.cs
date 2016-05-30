using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class ServiceLayoutHeader : Entity<long>
    {
        public virtual string Description { get; set; }
        public virtual ServiceTypeOrderServiceType ServiceTypeOrderServiceType { get; set; }
        public virtual IEnumerable<ServiceLayoutDetail> ServiceLayoutDetails { get; set; }
    }
}
