using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class OrderServiceWorkflowProduct : Entity<long>
    {
        public virtual Product Product { get; set; }

        #region HasMany
        public virtual IEnumerable<OrderServiceWorkflowProductComponent> OrderServiceWorkflowProductComponents { get; set; }
        #endregion
    }
}
