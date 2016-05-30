using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class ContractOperation : Entity<long>
    {
        public virtual Operation Operation { get; set; }
        public virtual ContractService ContractService { get; set; }

        #region HasMany
        public virtual IEnumerable<OperationServiceType> OperationServiceTypes { get; set; }
        #endregion

        public ContractOperation() { }
    }
}
