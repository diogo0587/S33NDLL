using System;
using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class Support : Entity<long>
    {
        public virtual OrderService OrderService { get; set; }
        public virtual bool Enable { get; set; }
        public virtual SupportOption SupportOption { get; set; }
        public virtual IEnumerable<SupportDetail> SupportDetails { get; set; }
    }
}
