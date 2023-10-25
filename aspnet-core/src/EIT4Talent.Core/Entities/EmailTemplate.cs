using Abp.Domain.Entities;
using EIT4Talent.Constants.Enum;
using System.ComponentModel.DataAnnotations;

namespace EIT4Talent.Entities
{
    public class EmailTemplate : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public string Name { get; set; }
        public string BodyMessage { get; set; }
        public string Subject { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public MailFuncEnum Type { get; set; }
        [MaxLength(200)]
        public string CCs { get; set; }
    }
}