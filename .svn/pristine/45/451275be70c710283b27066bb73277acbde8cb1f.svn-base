using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class GlobalizationResource : Entity<long>
    {
        [StringLength(200)]
        public virtual string ResourceName { get; set; }
        [Required]
        [StringLength(4000)]
        public virtual string ResourceValue { get; set; }
        [Required]
        [StringLength(10)]
        public virtual string CultureName { get; set; }
        public virtual long OperationId { get; set; }
    }
}
