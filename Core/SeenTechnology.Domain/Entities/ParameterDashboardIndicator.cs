using System;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class ParameterDashboardIndicator : Entity<long>
    {
        [StringLength(60)]
        public virtual string Description { get; set; }
        public virtual double MinValue { get; set; }
        public virtual double MaxValue { get; set; }
        [StringLength(20)]
        public virtual string MaxColorValue { get; set; }
        [StringLength(20)]
        public virtual string MinColorValue { get; set; }
        [StringLength(20)]
        public virtual string MiddleColorValue { get; set; }
        public virtual Operation Operation { get; set; }
        public virtual Account Account { get; set; }
        public virtual DateTime LastUpdate { get; set; }

        public ParameterDashboardIndicator() { }
    }
}
