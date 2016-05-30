using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class Operation : Entity<long>
    {
        [StringLength(50)]
        public virtual string Description { get; set; }
        public virtual DateTime Expiration { get; set; }
        public virtual Segment Segment { get; set; }
        public virtual Customer Customer { get; set; }
        [Required]
        public virtual bool CreateOccurProceda { get; set; }
        [StringLength(200)]
        public virtual string PathLogo { get; set; }
        [StringLength(200)]
        public virtual string Path { get; set; }
        public virtual int DeliveryAttempts { get; set; }
        public virtual bool NotSendRepiqueInLastDeliveryAttempts { get; set; }
        public virtual bool CheckMinimunDistanceToStartJob { get; set; }
        public virtual int MinimunDistanceToStartJob { get; set; }
        public virtual bool IssueCte { get; set; }
        [StringLength(100)]
        public virtual string NextWorkAlertMessage { get; set; }
        public virtual int AddrLevel { get; set; }
        [StringLength(80)]
        public virtual string OrderBy { get; set; }
        public virtual bool OsInLoco { get; set; }
        public virtual bool? SchedulingRoute { get; set; }
        [StringLength(10)]
        public virtual string NetworkType { get; set; }

        #region HasMany
        public virtual IEnumerable<OperationEventRepique> OperationEventsRepiques { get; set; }
        public virtual IEnumerable<AlertOperation> AlertOperations { get; set; }
        public virtual IEnumerable<ApplicationFlowSetup> ApplicationFlowSetups { get; set; }
        public virtual IEnumerable<Component> Components { get; set; }
        public virtual IEnumerable<ContractOperation> ContractOperations { get; set; }
        public virtual IEnumerable<ParameterDashboardIndicator> ParameterDashboardIndicators { get; set; }
        public virtual IEnumerable<DashQualityIndicator> DashQualityIndicators { get; set; }
        public virtual IEnumerable<DashSafetyIndicator> DashSafetyIndicators { get; set; }
        public virtual IEnumerable<ImportOrderService> ImportOrderServices { get; set; }
        public virtual IEnumerable<ImportOrderServiceFile> ImportOrderServiceFiles { get; set; }
        public virtual IEnumerable<OrderServiceType> OrderServiceTypes { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
        public virtual IEnumerable<Question> Questions { get; set; }
        public virtual IEnumerable<Questionnarie> Questionnaries { get; set; }
        public virtual IEnumerable<Scheduler> Schedulers { get; set; }
        public virtual IEnumerable<SendWorkflowToCustomer> SendWorkflowToCustomers { get; set; }
        public virtual IEnumerable<ServiceWorkflowConfiguration> ServiceWorkflowConfigurations { get; set; }
        public virtual IEnumerable<StartPointOperation> StartPointOperations { get; set; }
        public virtual IEnumerable<UiConfigurationMobile> UiConfigurationMobiles { get; set; }
        #endregion


        public Operation() { }

    }
}
