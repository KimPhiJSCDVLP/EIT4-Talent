using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EIT4Talent.Entities
{
    public class RequestSkill : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public long RequestId { get; set; }
        [ForeignKey(nameof(RequestId))]
        public Request Request { get; set; }
        public long SkillId { get; set; }
        [ForeignKey(nameof(SkillId))]
        public Skill Skill { get; set; }
    }
}