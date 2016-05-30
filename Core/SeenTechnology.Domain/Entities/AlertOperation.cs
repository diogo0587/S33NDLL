using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class AlertOperation : Entity<long>
    {
        [Required]
        public virtual Alert Alert { get; set; }
        [Required]
        public virtual Operation Operation { get; set; }
    }
}
