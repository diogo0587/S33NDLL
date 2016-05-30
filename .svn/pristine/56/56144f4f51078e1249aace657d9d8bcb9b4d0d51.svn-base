using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class Component : Entity<long>
    {
        [StringLength(100)]
        public virtual string Description { get; set; }
        [StringLength(50)]
        public virtual string SerialNumber { get; set; }
        [StringLength(50)]
        public virtual string Protocol { get; set; }
        [StringLength(30)]
        public virtual string ExternalId { get; set; }
        public virtual ComponentType ComponentType { get; set; }
        public virtual ComponentModel ComponentModel { get; set; }
        public virtual Operation Operation { get; set; }

        #region HasMany
        public virtual IEnumerable<OrderServiceDetail> OrderServiceDetail { get; set; }
        public virtual IEnumerable<OrderServiceWorkflowProductComponent> OrderServiceWorkflowProductComponent { get; set; }
        public virtual IEnumerable<ProductComponent> ProductComponent { get; set; }
        public virtual IEnumerable<RouteComponent> RouteComponent { get; set; }
        #endregion

        public Component() { }
    }
}
