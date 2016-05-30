using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class ServiceType : Entity<long>
    {
        public virtual string Description { get; set; }
        public virtual IEnumerable<OperationServiceType> OperationServiceTypes { get; set; }
    }
}
