using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class ZipCodeRange : Entity<long>
    {
        public virtual int RangeStart { get; set; }
        public virtual int RangeEnd { get; set; }
        public virtual IEnumerable<ZipCodeRangeStartPointOperation> ZipCodeRangeStartPointOperations { get; set; }
    }
}
