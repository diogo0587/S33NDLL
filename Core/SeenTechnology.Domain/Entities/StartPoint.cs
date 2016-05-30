using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class StartPoint : Entity<long>
    {
        [Required]
        public virtual string Description { get; set; }
        [Required]
        public virtual string Auxiliary1 { get; set; }
        public virtual string Auxiliary2 { get; set; }
        public virtual string Auxiliary3 { get; set; }
        public virtual string Auxiliary4 { get; set; }
        public virtual string Auxiliary5 { get; set; }
        [Required]
        public virtual Customer Customer { get; set; }
        [Required]
        public virtual Address Address { get; set; }

        public virtual IEnumerable<MobileDevice> MobileDevices { get; set; }
        public virtual IEnumerable<StartPointOperation> StartPointOperations { get; set; }
        public virtual IEnumerable<Technician> Technicians { get; set; }
    }
}
