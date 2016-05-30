using System;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class BiorecycleTemplate : Entity<long>
    {
        [Required]
        [StringLength(255)]
        public virtual string Filename { get; set; }
        public virtual Technician Technician { get; set; }
        public virtual MobileDevice MobileDevice { get; set; }
        [Required]
        public virtual bool Enable { get; set; }
        public virtual DateTime? Download { get; set; }
        public virtual DateTime? Confirm { get; set; }
    }
}
