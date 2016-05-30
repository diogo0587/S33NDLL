using System;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class Holiday : Entity<long>
    {
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? FinalDate { get; set; }
        [StringLength(50)]
        public virtual string Description { get; set; }
        public virtual bool Enable { get; set; }
    }
}
