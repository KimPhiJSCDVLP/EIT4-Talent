using Abp.Application.Services;
using EIT4Talent.MultiTenancy.Dto;

namespace EIT4Talent.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

