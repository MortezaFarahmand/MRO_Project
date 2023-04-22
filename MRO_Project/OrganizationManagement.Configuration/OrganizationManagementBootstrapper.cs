using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrganizationManagement.Application;
using OrganizationManagement.Application.Contracts.Country;
using OrganizationManagement.Application.Contracts.Organization;
using OrganizationManagement.Application.Contracts.OrganizationGroup;
using OrganizationManagement.Application.Contracts.OrganizationPicture;
using OrganizationManagement.Application.Contracts.Slide;
using OrganizationManagement.Domain.CountryAgg;
using OrganizationManagement.Domain.OrganizationAgg;
using OrganizationManagement.Domain.OrganizationGroupAgg;
using OrganizationManagement.Domain.OrganizationPictureAgg;
using OrganizationManagement.Domain.SlideAgg;
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

            services.AddTransient<IOrganizationPictureApplication, OrganizationPictureApplication>();
            services.AddTransient<IOrganizationPictureRepository, OrganizationPictureRepository>();

            services.AddTransient<ISlideApplication, SlideApplication>();
            services.AddTransient<ISlideRepository, SlideRepository>();

            services.AddTransient<ICountryApplication, CountryApplication>();
            services.AddTransient<ICountryRepository, CountryRepository>();


            services.AddDbContext<OrganizationContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
