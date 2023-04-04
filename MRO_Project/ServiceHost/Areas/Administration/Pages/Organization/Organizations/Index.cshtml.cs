using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrganizationManagement.Application.Contracts.Organization;
using OrganizationManagement.Application.Contracts.OrganizationGroup;

namespace ServiceHost.Areas.Administration.Pages.Organization.Organizations
{
    public class OrganizationsModel : PageModel
    {
        public OrganizationSearchModel SearchModel;
        public List<OrganizationViewModel> Organizations;
        public SelectList OrganizationGroups;

        private readonly IOrganizationApplication _organizationApplication;
        private readonly IOrganizationGroupApplication _organizationGroupApplication;

        public OrganizationsModel(IOrganizationApplication organizationApplication, IOrganizationGroupApplication organizationGroupApplication)
        {
            _organizationApplication = organizationApplication;
            _organizationGroupApplication = organizationGroupApplication;
        }



        public void OnGet(OrganizationSearchModel searchModel)
        {
            OrganizationGroups = new SelectList(_organizationGroupApplication.GetOrganizationGroups(), "Id", "Name");
            Organizations = _organizationApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateOrganization());
        }

        public JsonResult OnPostCreate(CreateOrganization command)
        {
            var result = _organizationApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var organization = _organizationApplication.GetDetails(id);
            return Partial("Edit", organization);
        }

        public JsonResult OnPostEdit(EditOrganization command)
        {
            var result = _organizationApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
