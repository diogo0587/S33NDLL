using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class ServiceWorkflowConfiguration : Entity<long>
    {
        public virtual string Description { get; set; }
        public virtual Operation Operation { get; set; }
        public virtual bool Required { get; set; }
        public virtual bool SendOnline { get; set; }
        public virtual ServiceWorkflow ServiceWorkflow { get; set; }
        public virtual ServiceWorkflowConfigurationDetail ServiceWorkflowConfigurationDetail { get; set; }
        public virtual string FromTo { get; set; }
        public virtual IEnumerable<OrderServiceWorkflow> OrderServiceWorkflows { get; set; }
        public virtual IEnumerable<ServiceEventWorkflow> ServiceEventWorkflows { get; set; }
        public virtual IEnumerable<ServiceWorkflowConfigurationQuestionnarie> ServiceWorkflowConfigurationQuestionnaries { get; set; }
    }
}
