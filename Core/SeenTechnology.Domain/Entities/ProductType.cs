using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class ProductType : Entity<long>
    {
        [StringLength(100)]
        public virtual string Description { get; set; }
        [StringLength(250)]
        public virtual string ExternalId { get; set; }


        #region HasMany
        public virtual ICollection<OrderServiceDetail> OrderServiceDetails { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        #endregion

        public ProductType() { }
    }
}
