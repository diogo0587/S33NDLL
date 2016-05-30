using System;

namespace SeenTechnology.Domain.Entities
{
    public class OrderServiceField : Entity<long>
    {
        public virtual string Name { get; set; }
        public virtual bool Enable { get; set; }
        public virtual int Size { get; set; }
        public virtual string Description { get; set; }
        public virtual bool Required { get; set; }
        public virtual DateTime CreationDate { get; set; }
    }
}
