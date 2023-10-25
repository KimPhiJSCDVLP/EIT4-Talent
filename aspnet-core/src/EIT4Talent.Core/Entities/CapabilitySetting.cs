using EIT4Talent.Constants.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace EIT4Talent.Entities
{
    public class CapabilitySetting : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public UserType UserType { get; set; }
        [MaxLength(5000)]
        public string Note { get; set; }
        [MaxLength(5000)]
        public string GuideLine { get; set; }
        public long SubPositionId { get; set; }
        [ForeignKey(nameof(SubPositionId))]
        public SubPosition SubPosition { get; set; }
        public long CapabilityId { get; set; }
        [ForeignKey(nameof(CapabilityId))]
        public Capability Capability { get; set; }
        public int Factor { get; set; }
    }
}