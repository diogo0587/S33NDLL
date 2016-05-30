using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class ProductModel : Entity<long>
    {
        [StringLength(100)]
        public virtual string Description { get; set; }
        [StringLength(250)]
        public virtual string ExternalId { get; set; }

        #region HasMany
        public virtual IEnumerable<OrderServiceDetail> OrderServiceDetails { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
        #endregion

        public ProductModel() { }
    }
}
