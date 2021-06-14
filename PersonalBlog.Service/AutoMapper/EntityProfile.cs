using AutoMapper;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Service.Dtos.AboutMeDtos;
using PersonalBlog.Service.Dtos.AccountsDtos;
using PersonalBlog.Service.Dtos.AdminDtos;
using PersonalBlog.Service.Dtos.ArticlesDtos;
using PersonalBlog.Service.Dtos.ContactInfoDtos;
using PersonalBlog.Service.Dtos.EducationDtos;
using PersonalBlog.Service.Dtos.ExperiencesDtos;
using PersonalBlog.Service.Dtos.InterestsDtos;
using PersonalBlog.Service.Dtos.MessagesDtos;
using PersonalBlog.Service.Dtos.SiteIdentityDtos;
using PersonalBlog.Service.Dtos.SkillsDtos;
using PersonalBlog.Service.Dtos.SlidersDtos;
using PersonalBlog.Service.Dtos.SummaryDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Service.AutoMapper
{
    public class EntityProfile : Profile
    {
        public EntityProfile()
        {
            CreateMap<Summary, SummaryUpdateDto>().ReverseMap();
            CreateMap<Interests, InterestsAddDto>().ReverseMap();
            CreateMap<InterestsUpdateDto, Interests>().ReverseMap();
            CreateMap<AccountsAddDto, SocialMediaAccounts>().ReverseMap();
            CreateMap<AccountsUpdateDto, SocialMediaAccounts>().ReverseMap();
            CreateMap<SlidersAddDto, HomePageSliders>().ReverseMap();
            CreateMap<SlidersUpdateDto, HomePageSliders>().ReverseMap();
            CreateMap<SkillsAddDto, Skills>().ReverseMap();
            CreateMap<SkillsUpdateDto, Skills>().ReverseMap();
            CreateMap<ExperiencesAddDto, Experiences>().ReverseMap();
            CreateMap<ExperiencesUpdateDto, Experiences>().ReverseMap();
            CreateMap<MessagesAddDto, Messages>().ReverseMap();
            CreateMap<MessagesUpdateDto, Messages>().ReverseMap();
            CreateMap<SiteIdentityUpdateDto, SiteIdentity>().ReverseMap();
            CreateMap<AboutMeUpdateDto, AboutMe>().ReverseMap();
            CreateMap<AdminUpdateDto, Admin>().ReverseMap();
            CreateMap<EducationAddDto, Education>().ReverseMap();
            CreateMap<EducationUpdateDto, Education>().ReverseMap();
            CreateMap<ContactInfoUpdateDto, ContactInfo>().ReverseMap();
            CreateMap<ArticlesAddDto, Articles>().ReverseMap();
            CreateMap<ArticlesUpdateDto, Articles>().ReverseMap();

        }
    }
}
