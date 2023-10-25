using EIT4Talent.Constants.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;

namespace EIT4Talent.Entities
{
    public class CVSkill : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public Level Level { get; set; }
        [MaxLength(500)]
        public string Note { get; set; }

        public long SkillId { get; set; }
        [ForeignKey(nameof(SkillId))]
        public Skill Skill { get; set; }

        public long CVId { get; set; }
        [ForeignKey(nameof(CVId))]
        public CV CV { get; set; }
    }
}
