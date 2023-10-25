using Abp.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EIT4Talent.Entities
{
    public class Position : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Code { get; set; }
        [MaxLength(20)]
        public string ColorCode { get; set; }
        public ICollection<SubPosition> SubPositions { get; set; }
    }
}
