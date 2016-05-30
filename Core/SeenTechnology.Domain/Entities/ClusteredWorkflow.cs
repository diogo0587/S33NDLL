namespace SeenTechnology.Domain.Entities
{
    public class ClusteredWorkflow : Entity<long>
    {
        public virtual bool Synchronized { get; set; }
        public virtual OrderService OrderService { get; set; }
    }
}
