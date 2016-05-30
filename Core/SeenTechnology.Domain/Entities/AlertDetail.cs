using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class AlertDetail : Entity<long>
    {
        public virtual bool Enable { get; set; }
        [Required]
        public virtual Alert Alert { get; set; }
        [Required]
        public virtual TypeSendingAlert TypeSendingAlert { get; set; }
        [Required]
        [StringLength(255)]
        public virtual string Message { get; set; }
    }
}
