using Abp.Domain.Entities;
using EIT4Talent.Constants.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EIT4Talent.Entities
{
    public class RequestCVStatusChangeHistory : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public RequestCVStatus? FromStatus { get; set; }
        public DateTime TimeAt { get; set; }
        public RequestCVStatus ToStatus { get; set; }
        public long RequestCVId { get; set; }
        [ForeignKey(nameof(RequestCVId))]
        public RequestCV RequestCV { get; set; }
    }
}