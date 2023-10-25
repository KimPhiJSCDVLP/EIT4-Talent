using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;

namespace EIT4Talent.Entities
{
    public class Education : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        public long EducationTypeId { get; set; }
        [ForeignKey(nameof(EducationTypeId))]
        public EducationType EducationType { get; set; }
        [MaxLength(20)]
        public string ColorCode { get; set; }

        public ICollection<CVEducation> CVEducations { get; set; }
    }
}
