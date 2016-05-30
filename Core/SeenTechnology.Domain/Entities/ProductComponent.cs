namespace SeenTechnology.Domain.Entities
{
    public class ProductComponent : Entity<long>
    {
        public virtual Component Component { get; set; }
        public virtual Product Product { get; set; }
    }
}
