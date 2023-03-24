using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using _0_Framework.Infrastructure;
using OrganizationManagement.Application.Contracts.OrganizationGroup;
using OrganizationManagement.Domain.OrganizationGroupAgg;

namespace OrganizationManagement.Infrastructure.EFCore.Repository
{
    public class OrganizationGroupRepository : RepositoryBase<long, OrganizationGroup> , IOrganizationGroupRepository
    {
        private readonly OrganizationContext _context;

        public OrganizationGroupRepository(OrganizationContext context) : base(context )
        {
            _context = context;
        }



        public EditOrganizationGroup GetDetails(long id)
        {
            return _context.OrganizationGroups.Select(x => new EditOrganizationGroup()
            {
                Id = x.Id,
                Name = x.Name,
                Description =x.Description
                
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<OrganizationGroupViewModel> Search(OrganizationGroupSearchModel searchModel)
        {
            var query = _context.OrganizationGroups.Select(x => new OrganizationGroupViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                CreationDate = x.CreationDate.ToString()

            });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));

            if (!string.IsNullOrWhiteSpace(searchModel.Description))
                query = query.Where(x => x.Description.Contains(searchModel.Description));

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
