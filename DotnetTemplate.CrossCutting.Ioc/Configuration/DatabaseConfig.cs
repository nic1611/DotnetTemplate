using DotnetTemplate.Infra.Data.Postgres.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetTemplate.Infra.CrossCutting.Ioc.Configuration {
    public static class DatabaseConfig {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration) {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<IdentityUserDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

        }
    }
}
