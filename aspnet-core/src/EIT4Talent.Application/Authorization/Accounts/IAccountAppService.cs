using System.Threading.Tasks;
using Abp.Application.Services;
using EIT4Talent.Authorization.Accounts.Dto;

namespace EIT4Talent.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
