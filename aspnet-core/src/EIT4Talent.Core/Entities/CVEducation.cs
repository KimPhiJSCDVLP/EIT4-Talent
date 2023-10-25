using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EIT4Talent.Entities
{
    public class CVEducation : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public long EducationId { get; set; }
        [ForeignKey(nameof(EducationId))]
        public Education Education { get; set; }
        public long CVId { get; set; }
        [ForeignKey(nameof(CVId))]
        public CV CV { get; set; }
    }
}