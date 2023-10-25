using Abp.Domain.Entities;
using EIT4Talent.Constants.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EIT4Talent.Entities
{
    public class CVSource : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public CVSourceReferenceType? ReferenceType { get; set; }
        [MaxLength(20)]
        public string ColorCode { get; set; }
        public ICollection<CV> CVs { get; set; }
    }
}

