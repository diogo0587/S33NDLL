using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class AccountStartPointOperation : Entity<long>
    {
        [Required]
        public virtual Account Account { get; set; }
        [Required]
        public virtual StartPointOperation StartPointOperation { get; set; }
    }
}
