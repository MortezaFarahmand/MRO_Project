
using System;

namespace OrganizationManagement.Application.Contracts.ApprovalAutority
{
    public class CreateApprovalAutority
    {
        public string NameEn { get; set; }
        public string NameFa { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string WebSite { get; set; }
        public string Remark { get; set; }
        public string Code { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string MetaDescription { get; set; }
        public string Slug { get; set; }
        public string CanonicalAddress { get; set; }
        public string Keywords { get; set; }
    }

    public class EditApprovalAutority : CreateApprovalAutority
    {
        public long Id { get; set; }
    }

    public class ApprovalAutorityViewModel
    {
        public string NameEn { get; set; }
        public string NameFa { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string WebSite { get; set; }
        public string Remark { get; set; }
        public string Code { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string MetaDescription { get; set; }
        public string Slug { get; set; }
        public string CanonicalAddress { get; set; }
        public string Keywords { get; set; }
    }

    public class ApprovalAutoritySearchModel
    {
        public string NameEn { get; set; }
        public string NameFa { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
