using Abp.Domain.Entities;

namespace EIT4Talent.Entities
{
    public class GroupSkill : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public string Name { get; set; }
        public bool Default { get; set; }
    }
}
