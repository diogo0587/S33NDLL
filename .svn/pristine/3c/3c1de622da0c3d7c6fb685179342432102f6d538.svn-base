using System;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class AlertTrack : Entity<long>
    {
        public virtual bool Enable { get; set; }
        [Required]
        [StringLength(2048)]
        public virtual string Message { get; set; }
        [Required]
        public virtual TypeSendingAlert TypeSendingAlert { get; set; }
        [StringLength(255)]
        public virtual string ContactName { get; set; }
        [Required]
        [StringLength(255)]
        public virtual string SourceValue { get; set; }
        public virtual DateTime? DateTimeScheduling { get; set; }
        public virtual DateTime? DateTimeSend { get; set; }
        [StringLength(50)]
        public virtual string Ticket { get; set; }
        public virtual OrderService OrderService { get; set; }
        [Required]
        public virtual RecordStatus RecordStatus { get; set; }
        public virtual ApplicationFlow ApplicationFlow { get; set; }
    }
}
