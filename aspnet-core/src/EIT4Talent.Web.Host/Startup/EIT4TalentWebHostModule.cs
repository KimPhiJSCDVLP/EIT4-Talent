using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EIT4Talent.Configuration;

namespace EIT4Talent.Web.Host.Startup
{
    [DependsOn(
       typeof(EIT4TalentWebCoreModule))]
    public class EIT4TalentWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public EIT4TalentWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EIT4TalentWebHostModule).GetAssembly());
        }
    }
}
