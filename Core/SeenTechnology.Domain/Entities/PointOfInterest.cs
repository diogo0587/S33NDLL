using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class PointOfInterest : Entity<long>
    {
        [StringLength(100)]
        public virtual string Description { get; set; }
        public virtual double Latitude { get; set; }
        public virtual double Longitude { get; set; }

        public PointOfInterest() { }
    }
}
