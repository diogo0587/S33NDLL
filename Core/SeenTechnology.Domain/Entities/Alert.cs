using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class Alert : Entity<long>
    {
        [Required]
        [StringLength(80)]
        public virtual string ProcessName { get; set; }
        [Required]
        public virtual AlertType AlertType { get; set; }
        public virtual IEnumerable<AlertDetail> AlertDetails { get; set; }
    }
}
