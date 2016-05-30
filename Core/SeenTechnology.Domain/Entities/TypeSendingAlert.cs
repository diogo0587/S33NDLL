using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class TypeSendingAlert : Entity<long>
    {
        public virtual string Name { get; set; }
        public virtual IEnumerable<AlertDetail> AlertDetails { get; set; }
        public virtual IEnumerable<AlertTrack> AlertTrackings { get; set; }
    }
}
