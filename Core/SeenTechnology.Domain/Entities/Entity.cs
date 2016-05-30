using System;

namespace SeenTechnology.Domain.Entities
{
    public abstract class Entity<TEntityId>
    {
        public virtual TEntityId Id { get; set; }
    }
}
