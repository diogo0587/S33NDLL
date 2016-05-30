using System;
using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class NotSendServiceEventsAgain : Entity<long>
    {
        public virtual OrderService OrderService { get; set; }
        public virtual bool Enable { get; set; }
        public virtual DateTime? ProcessedDate { get; set; }

        #region HasMany
        public virtual IEnumerable<NotSendServiceEventsAgainDetail> NotSendServiceEventsAgainDetails { get; set; }
        #endregion
    }
}
