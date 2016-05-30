namespace SeenTechnology.Domain.Entities
{
    public class ImportOrderServiceFileDetail : Entity<long>
    {
        public virtual ImportOrderService ImportOrderService { get; set; }
        public virtual ImportOrderServiceFile ImportOrderServiceFile { get; set; }
    }
}
