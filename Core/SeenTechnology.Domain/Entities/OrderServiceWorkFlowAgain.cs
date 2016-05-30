using System;
using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class OrderServiceWorkFlowAgain : Entity<long>
    {
        public virtual OrderService OrderService { get; set; }
        public virtual RecordStatus RecordStatus { get; set; }
        public virtual DateTime? Proccessed { get; set; }

        #region HasMany
        public virtual IEnumerable<OrderServiceWorkflowAgainDetail> OrderServiceWorkflowAgainDetails { get; set; }
        #endregion

        public OrderServiceWorkFlowAgain() {}
    }
}
