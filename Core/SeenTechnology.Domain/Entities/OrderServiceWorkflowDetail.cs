namespace SeenTechnology.Domain.Entities
{
    public class OrderServiceWorkflowDetail : Entity<long>
    {
        public virtual OrderServiceWorkflow OrderServiceWorkflow { get; set; }
    }
}
