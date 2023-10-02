using System.Threading.Tasks;
using Abp.Application.Services;
using EIT4Talent.Sessions.Dto;

namespace EIT4Talent.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
