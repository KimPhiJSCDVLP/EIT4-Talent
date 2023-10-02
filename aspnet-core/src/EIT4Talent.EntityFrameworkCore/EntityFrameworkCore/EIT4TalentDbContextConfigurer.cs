using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace EIT4Talent.EntityFrameworkCore
{
    public static class EIT4TalentDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EIT4TalentDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EIT4TalentDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
