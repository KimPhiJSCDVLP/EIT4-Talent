using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EIT4Talent.Authorization.Roles;
using EIT4Talent.Authorization.Users;
using EIT4Talent.MultiTenancy;
using EIT4Talent.Entities;
using System;

namespace EIT4Talent.EntityFrameworkCore
{
    public class EIT4TalentDbContext : AbpZeroDbContext<Tenant, Role, User, EIT4TalentDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Post> Posts { get; set; }
        public DbSet<CV> CVs { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestCV> RequestCVs { get; set; }
        public EIT4TalentDbContext(DbContextOptions<EIT4TalentDbContext> options)
            : base(options)
        {
        }
    }
}
