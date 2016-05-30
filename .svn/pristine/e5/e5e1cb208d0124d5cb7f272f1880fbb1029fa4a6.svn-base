using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class NotSendServiceEventsAgainDetail : Entity<long>
    {
        public virtual ServiceEvent ServiceEvent { get; set; }
        public virtual NotSendServiceEventsAgain NotSendServiceEventsAgain { get; set; }
        [StringLength(75)]
        public virtual string FromTo { get; set; }
    }
}
