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
    public class SubPosition : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(10)]
        public string ColorCode { get; set; }

        [Required]
        public long PositionId { get; set; }
        [ForeignKey(nameof(PositionId))]
        public Position Position { get; set; }

        public ICollection<CapabilitySetting> CapabilitySettings { get; set; }
        public ICollection<CV> CVs { get; set; }
        public ICollection<Request> Requests { get; set; }
    }
}
