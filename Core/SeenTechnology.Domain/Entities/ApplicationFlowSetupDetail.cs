using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class ApplicationFlowSetupDetail : Entity<long>
    {
        public virtual RecordStatus RecordStatusFrom { get; set; }
        public virtual RecordStatus RecordStatusTo { get; set; }
        public virtual ApplicationFlowSetup ApplicationFlowSetup { get; set; }
        [Required]
        public virtual bool UpdateOrderServiceStatus { get; set; }
        [Required]
        public virtual bool UpdateOrderServiceTracking { get; set; }
        [Required]
        public virtual string Sequence { get; set; }
    }
}
