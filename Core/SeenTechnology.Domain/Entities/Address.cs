using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class Address : Entity<long>
    {
        [Required]
        [StringLength(9)]
        public virtual string ZipCode { get; set; }
        [Required]
        [StringLength(120)]
        public virtual string Street { get; set; }
        public virtual float? Latitude { get; set; }
        public virtual float? Longitude { get; set; }
        public virtual int Level { get; set; }
        public virtual City City { get; set; }
        [StringLength(80)]
        public virtual string Neighborhood { get; set; }
        [StringLength(150)]
        public virtual string Adjunct { get; set; }
        [StringLength(150)]
        public virtual string Number { get; set; }
        [StringLength(150)]
        public virtual string Complement { get; set; }

        #region HasMany
        public virtual IEnumerable<GroupAddressDetail> GroupAddressDetails { get; set; }
        public virtual IEnumerable<OrderService> OrderServices { get; set; }
        public virtual IEnumerable<StartPoint> StartPoints { get; set; }
        public virtual IEnumerable<Technician> Technicians { get; set; }
        #endregion
    }
}
