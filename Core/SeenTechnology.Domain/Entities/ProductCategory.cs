using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class ProductCategory : Entity<long>
    {
        [Required]
        [StringLength(20)]
        public virtual string Name { get; set; }
        [StringLength(80)]
        public virtual string Description { get; set; }

        #region HasMany
        public virtual IEnumerable<Product> Products { get; set; }
        #endregion

        public ProductCategory(){}
    }
}
