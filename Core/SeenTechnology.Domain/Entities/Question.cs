using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class Question : Entity<long>
    {
        [Required]
        [StringLength(255)]
        public virtual string Description { get; set; }
        [Required]
        public virtual bool Enable { get; set; }
        [Required]
        public virtual bool? Required { get; set; }
        public virtual int? Sequence { get; set; }
        public virtual QuestionType QuestionType { get; set; }
        public virtual Operation Operation { get; set; }

        #region HasMany
        public virtual IEnumerable<Alternative> Alternatives { get; set; }
        public virtual IEnumerable<CustomAlternative> CustomAlternatives { get; set; }
        public virtual ICollection<OrderServiceWorkflowQuestionResponse> OrderServiceWorkflowQuestionResponse { get; set; }
        #endregion

        public Question() { }
    }
}
