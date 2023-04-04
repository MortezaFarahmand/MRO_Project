using _0_Framework.Domain;
using OrganizationManagement.Application.Contracts.Organization;
using System.Collections.Generic;

namespace OrganizationManagement.Domain.OrganizationAgg
{
    public interface IOrganizationRepository : IRepository<long, Organization>
    {
        EditOrganization GetDetails(long id);
        List<OrganizationViewModel> Search(OrganizationSearchModel searchModel);
    }
}
