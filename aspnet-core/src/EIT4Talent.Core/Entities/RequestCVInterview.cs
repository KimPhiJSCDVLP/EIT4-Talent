using Abp.Domain.Entities;
using EIT4Talent.Authorization.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace EIT4Talent.Entities
{
    public class RequestCVInterview : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public long RequestCVId { get; set; }
        [ForeignKey(nameof(RequestCVId))]
        public virtual RequestCV RequestCV { get; set; }
        public long InterviewId { get; set; }
        [ForeignKey(nameof(InterviewId))]
        public virtual User Interview { get; set; }
    }
}