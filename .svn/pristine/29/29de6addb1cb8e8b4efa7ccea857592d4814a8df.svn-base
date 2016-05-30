using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class Alternative : Entity<long>
    {
        [Required]
        [StringLength(255)]
        public virtual string Description { get; set; }
        public virtual bool IsJustify { get; set; }
        [StringLength(255)]
        public virtual string JustifyText { get; set; }
        public virtual bool Required { get; set; }
        [Required]
        public virtual bool Enable { get; set; }
        public virtual int Sequence { get; set; }
        [StringLength(50)]
        public virtual string FromTo { get; set; }
        [Required]
        public virtual Question Question { get; set; }
        public virtual ServiceWorkflowConfiguration ServiceWorkflowConfiguration { get; set; }

        #region HasMany
        public virtual IEnumerable<OrderServiceWorkflowQuestionResponse> OrderServiceWorkflowQuestionResponses { get; set; }
        public virtual IEnumerable<ScanAuditingDetail> ScanAuditingDetails { get; set; }
        public virtual IEnumerable<ScanAuditingDetailTracking> ScanAuditingDetailTrackings { get; set; }
        #endregion
    }
}
