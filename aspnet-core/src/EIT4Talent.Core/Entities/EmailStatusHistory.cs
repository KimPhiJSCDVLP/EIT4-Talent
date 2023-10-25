using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;

namespace EIT4Talent.Entities
{
    public class EmailStatusHistory : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public long CVId { get; set; }
        [ForeignKey(nameof(CVId))]
        public CV CVs { get; set; }
        public long EmailTemplateId { get; set; }
        [ForeignKey(nameof(EmailTemplateId))]
        public EmailTemplate EmailTemplate { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
    }
}
