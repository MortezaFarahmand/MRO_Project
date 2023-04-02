using _0_Framework.Domain;

namespace OrganizationManagement.Domain.OrganizationGroupAgg
{
    public class OrganizationGroup : EntityBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Picture { get;  private set; }
        public string NameCode { get;  private set; }
        //public string PictureAlt { get;  set; }
        //public string PictureTitle { get;  set; }
        //public string Keywords { get;  set; }
        //public string MetaDescription { get;  set; }
        //public string Slug { get;  set; }
        //public List<Organization> Organizations { get;  set; }

        //public OrganizationGroup()
        //{
        //    Organizations = new List<Organization>();
        //}

        public OrganizationGroup(string name, string description, string picture, string nameCode)
        {
            Name = name;
            Description = description;
            Picture = picture;
            NameCode = nameCode;
            //PictureTitle = pictureTitle;
            //Keywords = keywords;
            //MetaDescription = metaDescription;
            //Slug = slug;
        }

        public void Edit(string name, string description, string picture, string nameCode)
        {
            Name = name;
            Description = description;
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;
            NameCode = nameCode;
            //PictureTitle = pictureTitle;
            //Keywords = keywords;
            //MetaDescription = metaDescription;
            //Slug = slug;
        }
    }
}
