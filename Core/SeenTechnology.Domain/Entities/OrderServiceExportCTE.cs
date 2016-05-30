using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class OrderServiceExportCte : Entity<long>
    {
        public virtual Account Account { get; set; }


        #region HasMany
        public virtual IEnumerable<OrderServiceExportCteDetail> OrderServiceExportCteDetails { get; set; }
        #endregion
    }
}
