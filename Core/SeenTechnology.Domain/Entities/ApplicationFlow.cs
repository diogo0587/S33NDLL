using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class ApplicationFlow : Entity<long>
    {
        [StringLength(100)]
        public virtual string Name { get; set; }
        [StringLength(250)]
        public virtual string Description { get; set; }

        #region
        public virtual IEnumerable<AlertTrack> AlertTracks { get; set; }
        public virtual IEnumerable<ApplicationFlowSetup> ApplicationFlowSetups { get; set; }
        #endregion
    }
}
