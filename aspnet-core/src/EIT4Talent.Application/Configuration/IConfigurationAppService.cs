using System.Threading.Tasks;
using EIT4Talent.Configuration.Dto;

namespace EIT4Talent.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
