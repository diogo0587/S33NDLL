using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class AlertAlternativeServiceEvent : Entity<long>
    {
        [Required]
        public virtual Alternative Alternative { get; set; }
        [Required]
        public virtual AlertDetail AlertDetail { get; set; }
        [Required]
        public virtual ServiceEvent ServiceEvent { get; set; }
    }
}
