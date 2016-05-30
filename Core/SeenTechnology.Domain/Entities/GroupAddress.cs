using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class GroupAddress : Entity<long>
    {
        #region HasMany
        public virtual IEnumerable<GroupAddressDetail> GroupAddressDetails { get; set; }
        public virtual IEnumerable<OrderService> Orderservices { get; set; }
        #endregion

        public GroupAddress() { }
    }
}
