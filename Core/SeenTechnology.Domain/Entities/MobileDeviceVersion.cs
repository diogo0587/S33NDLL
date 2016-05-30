using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class MobileDeviceVersion : Entity<long>
    {
        [StringLength(20)]
        public virtual string CurrentVersion { get; set; }
        [Required]
        [StringLength(100)]
        public virtual string FileName { get; set; }
        [Required]
        [StringLength(20)]
        public virtual string DeviceVersion { get; set; }
        public virtual bool Enable { get; set; }
        public virtual string Release { get; set; }

        #region HasMany
        public virtual IEnumerable<MobileDeviceControlVersion> MobileDeviceControlVersions { get; set; }
        #endregion


        public MobileDeviceVersion() { }
    }
}
