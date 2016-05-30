using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class ApplicationFlowSetup : Entity<long>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int Sequence { get; set; }
        public virtual bool Enable { get; set; }
        public virtual Operation Operation { get; set; }
        public virtual Account Account { get; set; }
        public virtual ServiceEvent ServiceEvent { get; set; }

        #region HasMany
        public virtual IEnumerable<ApplicationFlowSetupDetail> ApplicationFlowSetupDetails { get; set; }
        public virtual IEnumerable<ApplicationFlowEntryPoint> ApplicationFlowEntryPoints { get; set; }
        #endregion
    }
}
