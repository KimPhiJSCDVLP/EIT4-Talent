using Abp.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EIT4Talent.Entities
{
    public class Capability : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        [MaxLength(2000)]
        public string Name { get; set; }
        [MaxLength(5000)]
        public string Note { get; set; }
        [Required]
        public bool FromType { get; set; }
        public ICollection<CapabilitySetting> CapabilitySettings { get; set; }
        public ICollection<RequestCVCapabilityResult> RequestCVCapabilityResults { get; set; }
    }
}