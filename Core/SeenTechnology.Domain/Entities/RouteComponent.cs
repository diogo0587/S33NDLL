namespace SeenTechnology.Domain.Entities
{
    public class RouteComponent : Entity<long>
    {
        public virtual Route Route { get; set; }
        public virtual Component Component { get; set; }
    }
}
