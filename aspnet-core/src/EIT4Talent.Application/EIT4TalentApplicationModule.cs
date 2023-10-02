using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EIT4Talent.Authorization;

namespace EIT4Talent
{
    [DependsOn(
        typeof(EIT4TalentCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EIT4TalentApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EIT4TalentAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EIT4TalentApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
