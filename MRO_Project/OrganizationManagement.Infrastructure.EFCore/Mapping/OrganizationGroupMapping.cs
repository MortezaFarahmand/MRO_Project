using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizationManagement.Domain.OrganizationGroupAgg;

namespace OrganizationManagement.Infrastructure.EFCore.Mapping
{
    public class OrganizationGroupMapping : IEntityTypeConfiguration<OrganizationGroup>
    {
        public void Configure(EntityTypeBuilder<OrganizationGroup> builder)
        {
            builder.ToTable("OrganizationGroups");
            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500).IsRequired();
        }
    }
}
