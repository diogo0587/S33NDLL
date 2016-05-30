using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class GpsPosition : Entity<long>
    {
        public virtual double Latitude { get; set; }
        public virtual double Longitude { get; set; }
        public virtual DateTime Timestamp { get; set; }
        public virtual int? TimeZone { get; set; }
        [StringLength(255)]
        public virtual string Auxiliary1 { get; set; }
        [StringLength(255)]
        public virtual string Auxiliary2 { get; set; }
        public virtual MobileDevice Device { get; set; }
        public virtual Technician Techinician { get; set; }

        #region HasMany
        public virtual IEnumerable<OrderServiceWorkflow> OrderServiceWorkflows { get; set; }
        #endregion
        public GpsPosition() { }
    }
}
