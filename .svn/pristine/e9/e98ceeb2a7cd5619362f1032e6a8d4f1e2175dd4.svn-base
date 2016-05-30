using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class MessageType : Entity<long>
    {
        [StringLength(50)]
        public virtual string Name { get; set; }
        [StringLength(150)]
        public virtual string Description { get; set; }

        #region HasMany
        public virtual IEnumerable<SocketTracking> Sockettrackings { get; set; }
        #endregion


        public MessageType() { }
    }
}
