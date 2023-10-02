using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using EIT4Talent.Configuration;
using EIT4Talent.Web;

namespace EIT4Talent.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EIT4TalentDbContextFactory : IDesignTimeDbContextFactory<EIT4TalentDbContext>
    {
        public EIT4TalentDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EIT4TalentDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EIT4TalentDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EIT4TalentConsts.ConnectionStringName));

            return new EIT4TalentDbContext(builder.Options);
        }
    }
}
