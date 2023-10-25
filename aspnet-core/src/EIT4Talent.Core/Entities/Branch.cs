using Abp.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EIT4Talent.Entities
{
    public class Branch : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string DisplayName { get; set; }
        [MaxLength(20)]
        public string ColorCode { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        public ICollection<Request> Requests { get; set; }
        public ICollection<CV> CVs { get; set; }
    }
}