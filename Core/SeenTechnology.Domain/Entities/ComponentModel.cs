using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class ComponentModel : Entity<long>
    {
        [StringLength(100)]
        public virtual string Description { get; set; }
        [StringLength(30)]
        public virtual string ExternalId { get; set; }

        #region HasMany
        public virtual IEnumerable<OrderServiceDetailComponent> OrderServiceDetailComponents { get; set; }
        public virtual IEnumerable<Component> Components { get; set; }
        #endregion

        public ComponentModel() { }
    }
}
