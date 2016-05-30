namespace SeenTechnology.Domain.Entities
{
    public class ServiceWorkflowConfigurationDetail : Entity<long>
    {
        public virtual ServiceWorkflow ServiceWorkflow { get; set; }
    }
}
