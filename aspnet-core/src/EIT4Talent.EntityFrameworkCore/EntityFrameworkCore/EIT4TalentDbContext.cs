using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EIT4Talent.Authorization.Roles;
using EIT4Talent.Authorization.Users;
using EIT4Talent.MultiTenancy;

namespace EIT4Talent.EntityFrameworkCore
{
    public class EIT4TalentDbContext : AbpZeroDbContext<Tenant, Role, User, EIT4TalentDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EIT4TalentDbContext(DbContextOptions<EIT4TalentDbContext> options)
            : base(options)
        {
        }
    }
}
