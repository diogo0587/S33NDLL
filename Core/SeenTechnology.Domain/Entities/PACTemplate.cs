using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class PACTemplate : Entity<long>
    {
        [StringLength(20)]
        public virtual string TemplateCode { get; set; }
        [StringLength(50)]
        public virtual string TemplateName { get; set; }
        public virtual RecordStatus RecordStatus { get; set; }

        public PACTemplate() {}
    }
}
