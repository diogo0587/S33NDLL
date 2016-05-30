using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class LayoutParameter : Entity<long>
    {
        [StringLength(50)]
        public virtual string Name { get; set; }
        [StringLength(50)]
        public virtual string NameView { get; set; }

        #region HasMany
        public virtual IEnumerable<ServiceLayoutDetail> ServiceLayoutDetails { get; set; }
        #endregion

        public LayoutParameter() { }
    }
}
