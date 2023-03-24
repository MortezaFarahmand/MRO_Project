using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrganizationManagement.Application.Contracts.OrganizationGroup;

namespace ServiceHost.Areas.Administration.Pages.Organization.OrganizationGroups
{
    public class OrganizationGroupsModel : PageModel
    {
        public OrganizationGroupSearchModel SearchModel;
        public List<OrganizationGroupViewModel> OrganizationGroups;
        private readonly IOrganizationGroupApplication _organizationGroupApplication;

        public OrganizationGroupsModel(IOrganizationGroupApplication organizationGroupApplication)
        {
            _organizationGroupApplication = organizationGroupApplication;
        }



        public void OnGet(OrganizationGroupSearchModel searchModel)
        {
            OrganizationGroups = _organizationGroupApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateOrganizationGroup());
        }
    }
}
