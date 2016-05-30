using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class SupportOption : Entity<long>
    {
        public virtual string Description { get; set; }
        public virtual bool Enable { get; set; }
        public virtual string Name { get; set; }
        public virtual IEnumerable<Support> Supports { get; set; }
    }
}
