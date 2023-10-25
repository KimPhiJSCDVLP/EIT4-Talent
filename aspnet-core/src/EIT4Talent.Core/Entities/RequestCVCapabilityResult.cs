using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;

namespace EIT4Talent.Entities
{
    public class RequestCVCapabilityResult : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public int Score { get; set; }
        [MaxLength(1000)]
        public string Note { get; set; }

        public long RequestCVId { get; set; }
        [ForeignKey(nameof(RequestCVId))]
        public RequestCV RequestCV { get; set; }
        public long CapabilityId { get; set; }
        [ForeignKey(nameof(CapabilityId))]
        public Capability Capability { get; set; }
        public int Factor { get; set; }
    }
}
