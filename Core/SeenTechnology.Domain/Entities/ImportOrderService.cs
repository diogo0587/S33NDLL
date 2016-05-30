using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class ImportOrderService : Entity<long>
    {
        public virtual DateTime? LastUpdate { get; set; }
        [StringLength(255)]
        public virtual string Response { get; set; }
        public virtual Operation Operation { get; set; }
        public virtual RecordStatus Status { get; set; }
        public virtual OrderService OrderService { get; set; }
        public virtual Account Account { get; set; }

        #region Campos da Ordem de Serviço
        [StringLength(255)]
        public virtual string CorporateName { get; set; }
        public virtual DateTime? DateTimeScheduling { get; set; }
        [StringLength(255)]
        public virtual string ExternalId { get; set; }
        [StringLength(255)]
        public virtual string PhoneNumber1 { get; set; }
        [StringLength(255)]
        public virtual string PhoneNumber2 { get; set; }
        [StringLength(255)]
        public virtual string Protocol { get; set; }
        [StringLength(255)]
        public virtual string Reference { get; set; }
        [StringLength(255)]
        public virtual string WorkDay { get; set; }
        [StringLength(255)]
        public virtual string City { get; set; }
        [StringLength(255)]
        public virtual string Complement { get; set; }
        [StringLength(255)]
        public virtual string Neighborhood { get; set; }
        [StringLength(255)]
        public virtual string Number { get; set; }
        [StringLength(255)]
        public virtual string Street { get; set; }
        [StringLength(255)]
        public virtual string ZipCode { get; set; }
        [StringLength(255)]
        public virtual string UF { get; set; }
        [StringLength(255)]
        public virtual string CustomerReference { get; set; }
        [StringLength(255)]
        public virtual string Email { get; set; }
        #endregion

        #region HasMany
        public virtual IEnumerable<ImportOrderServiceFileDetail> ImportOrderServiceFileDetail { get; set; }
        #endregion


        public ImportOrderService() { }
    }
}
