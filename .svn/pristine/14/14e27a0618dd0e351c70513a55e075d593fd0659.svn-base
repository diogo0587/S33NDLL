using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class OrderServiceWorkflowToken : Entity<long>
    {
        [Required]
        [StringLength(180)]
        public virtual string Key { get; set; }
        public virtual OrderServiceWorkflow OrderServiceWorkflow { get; set; }
        public virtual OrderService OrderService { get; set; }

        public OrderServiceWorkflowToken() {}
    }
}
