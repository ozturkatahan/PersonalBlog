using PersonalBlog.Data.Abstract;
using PersonalBlog.Data.Concrete.EntityFramework.Contexts;
using PersonalBlog.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;
        private EfSummaryRepository _efSummaryRepository;
        private EfInterestRepository _efInterestRepository;
        private EfSocialMediaAccountsRepository _efSocialMediaAccountsRepository;
        private EfHomePageSlidersRepository _efHomePageSlidersRepository;
        private EfSkillsRepository _efSkillsRepository;
        private EfExperiencesRepository _efExperiencesRepository;
        private EfMessagesRepository _efMessagesRepository;
        private EfSiteIdentityRepository _efSiteIdentityRepository;
        private EfAboutMeRepository _efAboutMeRepository;
        private EfAdminRepository _efAdminRepository;
        private EfEducationRepository _efEducationRepository;
        private EfContactInfoRepository _efContactInfoRepository;
        private EfArticlesRepository _efArticlesRepository;
        private EfCategoriesRepository _efCategoriesRepository;
        private EfCommentsRepository _efCommentsRepository;

        public UnitOfWork(BlogContext context)
        {
            _context = context;
        }

        public ISummaryRepository Summary => _efSummaryRepository ?? new EfSummaryRepository(_context);

        public ISocialMediaAccountRepository SocialMediaAccounts => _efSocialMediaAccountsRepository ?? new EfSocialMediaAccountsRepository(_context);

        public ISkillsRepository Skills => _efSkillsRepository ?? new EfSkillsRepository(_context);

        public ISiteIdentityRepository SiteIdentity => _efSiteIdentityRepository ?? new EfSiteIdentityRepository(_context);

        public IMessagesRepository Messages => _efMessagesRepository ?? new EfMessagesRepository(_context);

        public IInterestsRepository Interests => _efInterestRepository ?? new EfInterestRepository(_context);

        public IHomePageSlidersRepository HomePageSliders => _efHomePageSlidersRepository ?? new EfHomePageSlidersRepository(_context);

        public IExperiencesRepository Experiences => _efExperiencesRepository ?? new EfExperiencesRepository(_context);

        public IEducationRepository Education => _efEducationRepository ?? new EfEducationRepository(_context);

        public IContactInfoRepository Contact => _efContactInfoRepository ?? new EfContactInfoRepository(_context);

        public ICommentRepository Comment => _efCommentsRepository ?? new EfCommentsRepository(_context);

        public ICategoriesRepository Categories => _efCategoriesRepository ?? new EfCategoriesRepository(_context);

        public IArticleRepository Article => _efArticlesRepository ?? new EfArticlesRepository(_context);

        public IAboutMeRepository AboutMe => _efAboutMeRepository ?? new EfAboutMeRepository(_context);

        public IAdminRepository Admin => _efAdminRepository ?? new EfAdminRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
