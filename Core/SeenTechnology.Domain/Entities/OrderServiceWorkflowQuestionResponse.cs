using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class OrderServiceWorkflowQuestionResponse : Entity<long>
    {
        [StringLength(255)]
        public virtual string Response { get; set; }
        public virtual Question Question { get; set; }
        public virtual Alternative Alternative { get; set; }
        public virtual CustomAlternative CustomAlternative { get; set; }
        public virtual Technician Technician { get; set; }
        public virtual OrderServiceWorkflow PrincipalOrderServiceWorkflow { get; set; }
        public virtual OrderServiceWorkflow SecondaryOrderServiceWorkflow { get; set; }

        public OrderServiceWorkflowQuestionResponse() {}
    }
}
