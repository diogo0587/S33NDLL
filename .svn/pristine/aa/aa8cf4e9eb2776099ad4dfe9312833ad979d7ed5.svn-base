using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class OrderServiceWorkflowAgainDetail : Entity<long>
    {
        [StringLength(100)]
        public virtual string ExternalId { get; set; }
        [StringLength(100)]
        public virtual string Note { get; set; }
        public virtual OrderServiceWorkFlowAgain OrderServiceWorkFlowAgain { get; set; }
    }
}
