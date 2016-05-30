using System;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class AccountSession : Entity<long>
    {
        [Required]
        public virtual Account Account { get; set; }
        [Required]
        public virtual Guid SessionGuid { get; set; }
        [Required]
        public virtual DateTime DateTimeExpiration { get; set; }
    }
}
