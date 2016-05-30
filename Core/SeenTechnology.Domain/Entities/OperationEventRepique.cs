namespace SeenTechnology.Domain.Entities
{
    public class OperationEventRepique : Entity<long>
    {
        public virtual Operation Operation { get; set; }
        public virtual ServiceEvent ServiceEvent { get; set; }
    }
}
