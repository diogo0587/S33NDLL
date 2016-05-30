using System.Collections.Generic;

namespace SeenTechnology.Domain.Entities
{
    public class OrderServiceDetail : Entity<long>
    {
        public virtual double Quantity { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ProductModel ProductModel { get; set; }
        public virtual Product Product { get; set; }
        public virtual OrderService OrderService { get; set; }

        #region HasMany
        public virtual IEnumerable<OrderServiceDetailComponent> OrderServiceDetailComponents { get; set; }
        #endregion

        public OrderServiceDetail() { }
    }
}
