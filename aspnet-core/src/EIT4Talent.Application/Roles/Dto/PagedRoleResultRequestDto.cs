using Abp.Application.Services.Dto;

namespace EIT4Talent.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

