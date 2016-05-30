using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class EDIDataType : Entity<int>
    {
        [Required]
        [StringLength(75)]
        public virtual string Name { get; set; }
        [Required]
        public virtual bool Enable { get; set; }

        #region HasMany
        public virtual IEnumerable<EDIDataDetail> EDIDataDetails { get; set; }
        #endregion

        public EDIDataType() { }
    }
}
