﻿using Abp.Domain.Entities;
using EIT4Talent.Constants.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EIT4Talent.Entities
{
    public class RequestCV : EIT4AuditEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public RequestCVStatus Status { get; set; }
        public DateTime? InterviewTime { get; set; }
        public Level? ApplyLevel { get; set; }
        public Level? InterviewLevel { get; set; }
        public Level? FinalLevel { get; set; }
        [MaxLength(1000)]
        public string HRNote { get; set; }
        public DateTime? OnboardDate { get; set; }
        public float Salary { get; set; }
        public long CVId { get; set; }
        [ForeignKey(nameof(CVId))]
        public CV CV { get; set; }
        public long RequestId { get; set; }
        [ForeignKey(nameof(RequestId))]
        public virtual Request Request { get; set; }
        public bool? EmailSent { get; set; }
        public bool? Interviewed { get; set; }
        public string Percentage { get; set; }
    }
}