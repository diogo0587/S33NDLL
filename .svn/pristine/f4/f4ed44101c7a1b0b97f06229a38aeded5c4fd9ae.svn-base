using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class Application : Entity<long>
    {
        [Required]
        [StringLength(100)]
        public virtual string Name { get; set; }

        #region HasMany
        public virtual IEnumerable<ApplicationFlow> ApplicationFlows { get; set; }
        #endregion
    }
}
