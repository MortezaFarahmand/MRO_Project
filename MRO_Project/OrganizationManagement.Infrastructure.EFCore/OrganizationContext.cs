using Microsoft.EntityFrameworkCore;
using OrganizationManagement.Domain.OrganizationGroupAgg;
using OrganizationManagement.Infrastructure.EFCore.Mapping;

namespace OrganizationManagement.Infrastructure.EFCore
{
    public class OrganizationContext : DbContext
    {
        public DbSet<OrganizationGroup> OrganizationGroups { get; set; }

        public OrganizationContext(DbContextOptions<OrganizationContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(OrganizationGroupMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }

}
