using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class OrderServiceWorkflow : Entity<long>
    {
        public virtual ServiceWorkflow ServiceWorkflow { get; set; }
        public virtual GpsPosition GpsPosition { get; set; }
        [StringLength(500)]
        public virtual string ElementName { get; set; }
        [StringLength(500)]
        public virtual string TypeElement { get; set; }
        [StringLength(500)]
        public virtual string TypeFieldElement { get; set; }
        public virtual int LenghtFieldElement { get; set; }
        public virtual bool RequiredElement { get; set; }
        public virtual string ContentElement { get; set; }
        public virtual string DefaultContent { get; set; }
        [StringLength(500)]
        public virtual string Situation { get; set; }
        public virtual RouteDetail RouteDetail { get; set; }
        public virtual OrderServiceAttendance OrderServiceAttendance { get; set; }
        public virtual ServiceWorkflowConfiguration ServiceWorkflowConfiguration { get; set; }

        #region HasMany
        public virtual ICollection<OrderServiceWorkflowDetail> OrderServiceWorkflowDetails { get; set; }
        public virtual ICollection<OrderServiceWorkflowQuestionResponse> OrderServiceWorkflowQuestionResponses { get; set; }
        public virtual ICollection<OrderServiceWorkflowToken> OrderServiceWorkflowTokens { get; set; }
        public virtual ICollection<OrderServiceWorkflowProduct> OrderServiceWorkflowProducts { get; set; }
        #endregion

        public OrderServiceWorkflow(){}
    }
}
