using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class ComponentType : Entity<long>
    {
        [StringLength(100)]
        public virtual string Description { get; set; }
        [StringLength(30)]
        public virtual string ExternalId { get; set; }

        #region HasMany

        public virtual IEnumerable<Component> Components { get; set; }
        public virtual IEnumerable<OrderServiceDetailComponent> OrderServiceDetailComponents { get; set; }
        #endregion

        public ComponentType() { }
    }
}
