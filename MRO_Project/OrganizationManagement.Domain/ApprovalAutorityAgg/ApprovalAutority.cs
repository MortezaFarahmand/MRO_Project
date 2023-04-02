using _0_Framework.Domain;


namespace OrganizationManagement.Domain.ApprovalAutorityAgg
{
    public class ApprovalAutority : EntityBase
    {
        public string NameEn { get; private set; }
        public string NameFa { get; private set; }
        public string Description { get; private set; }
        public string Address { get; private set; }
        public string WebSite { get; private set; }
        public string Remark { get; private set; }
        public string Code { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string MetaDescription { get; private set; }
        public string Slug { get; private set; }
        public string CanonicalAddress { get; private set; }
        public string Keywords { get; private set; }

        public ApprovalAutority(string nameEn, string nameFa, string description, string address, string webSite, 
            string remark, string code, string picture, string pictureAlt, string pictureTitle,
            string metaDescription, string slug, string canonicalAddress, string keywords)
        {
            NameEn = nameEn;
            NameFa = nameFa;
            Description = description;
            Address = address;
            WebSite = webSite;
            Remark = remark;
            Code = code;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            MetaDescription = metaDescription;
            Slug = slug;
            CanonicalAddress = canonicalAddress;
            Keywords = keywords;
        }
    }
}
