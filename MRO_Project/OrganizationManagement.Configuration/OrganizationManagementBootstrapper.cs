using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrganizationManagement.Application;
using OrganizationManagement.Application.Contracts.Organization;
using OrganizationManagement.Application.Contracts.OrganizationGroup;
using OrganizationManagement.Domain.OrganizationAgg;
using OrganizationManagement.Domain.OrganizationGroupAgg;
using OrganizationManagement.Infrastructure.EFCore;
using OrganizationManagement.Infrastructure.EFCore.Repository;

namespace OrganizationManagement.Configuration
{
    public class OrganizationManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IOrganizationGroupApplication, OrganizationGroupApplication>();
            services.AddTransient<IOrganizationGroupRepository, OrganizationGroupRepository>();

            services.AddTransient<IOrganizationApplication, OrganizationApplication>();
            services.AddTransient<IOrganizationRepository, OrganizationRepository>();

            services.AddDbContext<OrganizationContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
