using System;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class NotifyOrderService : Entity<long>
    {
        public virtual DateTime? LastUpdate { get; set; }
        public virtual RecordStatus RecordStatus { get; set; }
        [Required]
        [StringLength(255)]
        public virtual string TransportMode { get; set; }
        [StringLength(500)]
        public virtual string Reason { get; set; }
        public virtual RouteDetail RouteDetail { get; set; }
    }
}
