namespace SeenTechnology.Domain.Entities
{
    public class OrderServiceDetailComponent : Entity<long>
    {
        public virtual double Quantity { get; set; }
        public virtual ComponentModel ComponentModel { get; set; }
        public virtual ComponentType ComponentType { get; set; }
        public virtual Component Component { get; set; }
        public virtual bool Optional { get; set; }
    }
}
