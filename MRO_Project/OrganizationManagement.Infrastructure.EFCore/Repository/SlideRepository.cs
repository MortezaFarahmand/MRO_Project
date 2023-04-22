﻿using _0_Framework.Application;
using _0_Framework.Infrastructure;
using OrganizationManagement.Application.Contracts.Slide;
using OrganizationManagement.Domain.SlideAgg;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrganizationManagement.Infrastructure.EFCore.Repository
{
    public class SlideRepository : RepositoryBase<long, Slide>, ISlideRepository
    {
        private readonly OrganizationContext _context;

        public SlideRepository(OrganizationContext context) : base(context)
        {
            _context = context;
        }

        public EditSlide GetDetails(long id)
        {
            return _context.Slides.Select(x => new EditSlide
            {
                Id = x.Id,
                BtnText = x.BtnText,
                Heading = x.Heading,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Text = x.Text,
                Link = x.Link,
                Title = x.Title
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<SlideViewModel> GetList()
        {
            return _context.Slides.Select(x => new SlideViewModel
            {
                Id = x.Id,
                Heading = x.Heading,
                Picture = x.Picture,
                Title = x.Title,
                IsRemoved = x.IsRemoved,
                CreationDate = x.CreationDate.ToString("dd/MM/yyyy")
            }).OrderByDescending(x => x.Id).ToList();
        }
    }
}
