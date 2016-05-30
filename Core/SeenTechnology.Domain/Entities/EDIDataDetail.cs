using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class EDIDataDetail : Entity<long>
    {
        [Required]
        [StringLength(75)]
        public virtual string Name { get; set; }
        [Required]
        public virtual int StartPoisition { get; set; }
        [Required]
        public virtual bool Enable { get; set; }
        [Required]
        public virtual int Size { get; set; }
        [Required]
        public virtual int? DecimalPlaces { get; set; }
        [StringLength(150)]
        public virtual string Description { get; set; }[StringLength(150)]
        [Required]
        public virtual bool Required { get; set; }
        public virtual OrderServiceField OrderServiceField { get; set; }
        public virtual EDIDataType EDIDataType { get; set; }
        public virtual EDIData EDIData { get; set; }
        
    }
}
