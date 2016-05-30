namespace SeenTechnology.Domain.Entities
{
    public class ConsultProspectAccount : Entity<long>
    {
        public virtual OrderService OrderService { get; set; }
        public virtual RecordStatus RecordStatus { get; set; }
    }
}
