using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class City : Entity<long>
    {
        [StringLength(50)]
        public virtual string Name { get; set; }
        [StringLength(50)]
        public virtual string NameGoogle { get; set; }
        [StringLength(2)]
        public virtual string State { get; set; }
        [StringLength(9)]
        public virtual string ZipCode0 { get; set; }
        [StringLength(9)]
        public virtual string ZipCode1 { get; set; }
        public virtual double Latitude { get; set; }
        public virtual double Longitude { get; set; }
        public virtual double Latitude0 { get; set; }
        public virtual double Longitude0 { get; set; }
        public virtual double Latitude1 { get; set; }
        public virtual double Longitude1 { get; set; }

        #region HasMany
        public virtual IEnumerable<Address> Addresses { get; set; }
        #endregion

        public City() { }
    }
}
