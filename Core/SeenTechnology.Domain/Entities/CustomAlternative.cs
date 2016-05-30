using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class CustomAlternative : Entity<long>
    {
        public virtual string Description { get; set; }
        public virtual bool IsJustify { get; set; }
        public virtual string JustifyText { get; set; }
        public virtual bool Required { get; set; }
        public virtual bool Enable { get; set; }
        public virtual int Sequence { get; set; }
        public virtual string FromTo { get; set; }
        public virtual Question Question { get; set; }
        public virtual OrderService OrderService { get; set; }

        #region HasMany

        public virtual IEnumerable<OrderServiceWorkflowQuestionResponse> OrderServiceWorkflowQuestionResponses { get; set; }
        #endregion

        public CustomAlternative() { }
    }
}
