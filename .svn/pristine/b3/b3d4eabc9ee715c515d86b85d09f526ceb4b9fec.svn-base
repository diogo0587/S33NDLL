using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class ServiceLayoutDetail : Entity<long>
    {
        public virtual string FieldName { get; set; }
        public virtual string FieldType { get; set; }
        public virtual bool ShowGrid { get; set; }
        public virtual string Description { get; set; }
        public virtual int Sequence { get; set; }
        public virtual bool GridColumn { get; set; }
        public virtual bool Enable { get; set; }
        public virtual LayoutParameter LayoutParameter { get; set; }
        public virtual IEnumerable<OrderServiceLayout> OrderServiceLayouts { get; set; }
    }
}
