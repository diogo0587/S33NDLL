using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class EDIData : Entity<long>
    {
        [Required]
        [StringLength(5)]
        public virtual string Prefix { get; set; }
        [Required]
        [StringLength(75)]
        public virtual string Name { get; set; }
        public virtual bool Enable { get; set; }

        #region HasMany
        public virtual IEnumerable<EDIDataDetail> EDIDataDetails { get; set; }
        #endregion

        public EDIData() { }
    }
}
