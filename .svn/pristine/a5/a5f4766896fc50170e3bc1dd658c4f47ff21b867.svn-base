using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeenTechnology.Domain.Entities
{
    public class ImportOrderServiceFile : Entity<long>
    {
        [StringLength(255)]
        public virtual string Response { get; set; }
        [Required]
        [StringLength(255)]
        public virtual string FileName { get; set; }
        [Required]
        public virtual int BytesReceived { get; set; }
        [Required]
        public virtual int TotalOrderServices { get; set; }
        public virtual DateTime? LastUpdate { get; set; }
        public virtual Operation Operation { get; set; }
        public virtual Account Account { get; set; }
        public virtual RecordStatus RecordStatus { get; set; }
        public virtual IEnumerable<ImportOrderServiceFileDetail> ImportOrderServiceFileDetails { get; set; }
    }
}
