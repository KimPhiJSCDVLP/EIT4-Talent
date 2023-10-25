using Abp.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EIT4Talent.Entities
{
    public class Skill : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public long? GroupSkillId { get; set; }
        [ForeignKey(nameof(GroupSkillId))]
        public GroupSkill GroupSkill { get; set; }
        public ICollection<RequestSkill> RequestSkills { get; set; }
        public ICollection<CVSkill> CVSkills { get; set; }
    }
}
