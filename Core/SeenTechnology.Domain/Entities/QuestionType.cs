using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class QuestionType : Entity<long>
    {
        [Required]
        [StringLength(255)]
        public virtual string Description { get; set; }
        [Required]
        [StringLength(255)]
        public virtual string Name { get; set; }
        [Required]
        public virtual bool Scan { get; set; }

        #region HasMany
        public virtual IEnumerable<Question> Questions { get; set; }
        #endregion

        public QuestionType() { }

    }
}
