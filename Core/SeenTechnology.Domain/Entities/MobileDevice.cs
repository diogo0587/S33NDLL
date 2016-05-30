using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class MobileDevice : Entity<long>
    {
        [StringLength(50)]
        public virtual string Model { get; set; }
        [StringLength(50)]
        public virtual string Manufacturer { get; set; }
        [StringLength(30)]
        public virtual string Imei { get; set; }
        public virtual bool Enable { get; set; }
        public virtual bool Lost { get; set; }
        public virtual StartPoint StartPoint { get; set; }


        #region HasMany
        public virtual IEnumerable<BiorecycleTemplate> BiorecycleTemplates { get; set; }
        public virtual IEnumerable<DeviceAllocated> DeviceAllocateds { get; set; }
        public virtual IEnumerable<GpsPosition> GpsPositions { get; set; }
        public virtual IEnumerable<MobileDeviceControlVersion> MobileDeviceControlVersions { get; set; }
        public virtual IEnumerable<Route> Routes { get; set; }
        public virtual IEnumerable<SocketTracking> SocketTrackings { get; set; }
        #endregion


        public MobileDevice() { }
    }
}
