using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class PAC : Entity<long>
    {
        [StringLength(50)]
        public virtual string FileName { get; set; }
        public virtual string Json { get; set; }
        [StringLength(10)]
        public virtual string TemplateCode { get; set; }
        public virtual RecordStatus RecordStatus { get; set; }
        public virtual OrderServiceCustomer OrderServiceCustomer { get; set; }

        public PAC() {}
    }
}
