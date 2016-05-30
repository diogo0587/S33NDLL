namespace SeenTechnology.Domain.Entities
{
    public class AlertTypeDetail : Entity<long>
    {
        public virtual string Content { get; set; }
        public virtual string Value { get; set; }
    }
}
