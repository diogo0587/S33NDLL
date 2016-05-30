using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class ImageType : Entity<long>
    {
        [StringLength(200)]
        public virtual string Description { get; set; }


        #region HasMany
        public virtual IEnumerable<Images> Images { get; set; }
        #endregion


        public ImageType() { }
    }
}
