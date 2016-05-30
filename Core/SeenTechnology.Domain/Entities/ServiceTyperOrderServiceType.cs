namespace SeenTechnology.Domain.Entities
{
    public class ServiceTyperOrderServiceType : Entity<long>
    {        
        public virtual string Reference { get; set; }
        public virtual OrderServiceType OrderServiceType { get; set; }
    }
}
