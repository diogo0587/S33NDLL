using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class Product : Entity<long>
    {
        [StringLength(250)]
        public virtual string Description { get; set; }
        [StringLength(250)]
        public virtual string Protocol { get; set; }
        [StringLength(250)]
        public virtual string SerialNumber { get; set; }
        [StringLength(250)]
        public virtual string ExternalId { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ProductModel ProductModel { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual Operation Operation { get; set; }

        #region HasMany
        public virtual ICollection<OrderServiceDetail> OrderServiceDetails { get; set; }
        public virtual ICollection<OrderServiceWorkflowProduct> OrderServiceWorkflowProducts { get; set; }
        public virtual ICollection<ProductComponent> ProductComponents { get; set; }
        public virtual ICollection<RouteProduct> RouteProducts { get; set; }
        #endregion
    }
}
