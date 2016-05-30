using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class OperationServiceType : Entity<long>
    {
        public virtual ServiceType ServiceType { get; set; }
        public virtual ContractOperation ContractOperation { get; set; }

        #region HasMany
        public virtual IEnumerable<ServiceTypeOrderServiceType> ServiceTypeOrderServiceTypes { get; set; }
        #endregion


        public OperationServiceType() { }
    }
}
