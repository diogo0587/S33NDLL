using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class RequestTracking : Entity<long>
    {
        [StringLength(255)]
        public virtual string Method { get; set; }
        public virtual int Quantity { get; set; }
        [StringLength(255)]
        public virtual string Protocol { get; set; }
        public virtual RecordStatus RecordStatus { get; set; }
        [StringLength(255)]
        public virtual string Error { get; set; }
        [StringLength(15)]
        public virtual string TimeStart { get; set; }
        [StringLength(15)]
        public virtual string TimeEnd { get; set; }
        public virtual DateTime? CreationDate { get; set; }

        #region HasMany
        public virtual IEnumerable<OrderService> OrderServices { get; set; }
        public virtual IEnumerable<RequestTrackingDetail> RequestTrackingDetails { get; set; }
        #endregion

        public RequestTracking() { }

    }
}
