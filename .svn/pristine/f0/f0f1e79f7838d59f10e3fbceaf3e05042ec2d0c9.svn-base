using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class DashboardEventType : Entity<long>
    {
        [StringLength(50)]
        public virtual string Description { get; set; }
        [StringLength(50)]
        public virtual string Name { get; set; }

        #region HasMany
        public virtual IEnumerable<DashboardEvent> DashboardEvents { get; set; }
        #endregion

        public DashboardEventType() { }
    }
}
