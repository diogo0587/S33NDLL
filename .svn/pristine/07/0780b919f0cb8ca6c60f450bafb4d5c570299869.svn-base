using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class Questionnarie : Entity<long>
    {
        public virtual string Description { get; set; }
        public virtual bool Enable { get; set; }
        public virtual Operation Operation { get; set; }

        #region HasMany
        public virtual IEnumerable<Question> Questions { get; set; }
        public virtual ICollection<ServiceWorkflowConfigurationQuestionnarie> ServiceWorkflowConfigurationQuestionnarie { get; set; }
        #endregion

        public Questionnarie() { }
    }
}
