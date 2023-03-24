using _0_Framework.Domain;

namespace OrganizationManagement.Domain.OrganizationGroupAgg
{
    public class OrganizationGroup : EntityBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public OrganizationGroup(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Edit(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
