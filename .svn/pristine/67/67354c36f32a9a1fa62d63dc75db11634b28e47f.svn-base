using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class ServiceEvent : Entity<long>
    {
        public virtual string DescriptionBefore { get; set; }
        public virtual string DescriptionAfter { get; set; }
        public virtual bool Enable { get; set; }
        public virtual bool LastEvent { get; set; }
        public virtual bool SendOnline { get; set; }
        public virtual ServiceTypeOrderServiceType ServiceTypeOrderServiceType { get; set; }
        public virtual IEnumerable<ServiceEventWorkflow> ServiceEventWorkflows { get; set; }
        public virtual bool FixedMenu { get; set; }
        public virtual string Auxiliary1 { get; set; }
        public virtual OrderServiceType OrderServiceType { get; set; }
        public virtual ServiceEventType ServiceEventType { get; set; }
        public virtual ServiceEventGroup ServiceEventGroup { get; set; }
        public virtual IEnumerable<AlertAlternativeServiceEvent> AlertAlternativeServiceEvents { get; set; }
        public virtual IEnumerable<ApplicationFlowSetup> ApplicationFlowSetups { get; set; }
        public virtual IEnumerable<NotSendServiceEventsAgainDetail> NotSendServiceEventsAgainDetails { get; set; }
        public virtual IEnumerable<OperationEventRepique> OperationEventRepiques { get; set; }
        public virtual IEnumerable<OrderServiceAttendance> OrderServiceAttendances { get; set; }
        public virtual IEnumerable<RouteDetail> RouteDetails { get; set; }
    }
}
