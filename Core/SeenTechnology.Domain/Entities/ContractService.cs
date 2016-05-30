using System;
using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class ContractService : Entity<long>
    {
        public virtual string Description { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual DateTime Expiration { get; set; }
        public virtual string Auxiliary1 { get; set; }
        public virtual string Auxiliary2 { get; set; }
        public virtual string Auxiliary3 { get; set; }
        public virtual string Auxiliary4 { get; set; }
        public virtual string Auxiliary5 { get; set; }

        #region HasMany
        public virtual IEnumerable<ContractOperation> ContractOperations { get; set; }
        #endregion

        public ContractService() { }
    }
}
