using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class ServiceWorkflow : Entity<long>
    {
        public virtual string ElementName { get; set; }
        public virtual string TypeElement { get; set; }
        public virtual string TypeFieldElement { get; set; }
        public virtual int LengthFieldElement { get; set; }
        public virtual bool RequiredElement { get; set; }
        public virtual string ContentElement { get; set; }
        public virtual decimal Score { get; set; }
        public virtual string DefaultContent { get; set; }
        public virtual string Situation { get; set; }
        public virtual bool SendOnline { get; set; }
        public virtual IEnumerable<OrderServiceWorkflow> OrderServiceWorkflows { get; set; }
        public virtual IEnumerable<ServiceEventWorkflow> ServiceEventWorkflows { get; set; }
        public virtual IEnumerable<ServiceWorkflowConfiguration> ServiceWorkflowConfigurations { get; set; }
        public virtual IEnumerable<ServiceWorkflowConfigurationDetail> ServiceWorkflowConfigurationDetails { get; set; }
    }
}
