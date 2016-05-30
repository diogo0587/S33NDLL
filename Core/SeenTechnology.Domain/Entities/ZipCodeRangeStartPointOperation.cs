namespace SeenTechnology.Domain.Entities
{
    public class ZipCodeRangeStartPointOperation : Entity<long>
    {
        public virtual ZipCodeRange ZipCodeRange { get; set; }
    }
}
