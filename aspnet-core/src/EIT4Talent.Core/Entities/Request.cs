using Abp.Domain.Entities;
using EIT4Talent.Constants.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EIT4Talent.Entities
{
    public class Request : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        [MaxLength(1000)]
        public string Note { get; set; }
        public Level Level { get; set; }
        public int Quantity { get; set; }
        public StatusRequest Status { get; set; }
        public UserType UserType { get; set; }
        public long? ProjectToolRequestId { get; set; }
        public DateTime? TimeNeed { get; set; }
        public Priority Priority { get; set; }
        public ICollection<RequestCV> RequestCVs { get; set; }
    }
}
