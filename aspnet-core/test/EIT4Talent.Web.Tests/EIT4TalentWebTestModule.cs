using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EIT4Talent.EntityFrameworkCore;
using EIT4Talent.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace EIT4Talent.Web.Tests
{
    [DependsOn(
        typeof(EIT4TalentWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class EIT4TalentWebTestModule : AbpModule
    {
        public EIT4TalentWebTestModule(EIT4TalentEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EIT4TalentWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(EIT4TalentWebMvcModule).Assembly);
        }
    }
}