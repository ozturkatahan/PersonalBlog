using PersonalBlog.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        ISummaryRepository Summary { get; }
        ISocialMediaAccountRepository SocialMediaAccounts { get; }
        ISkillsRepository Skills { get; }
        ISiteIdentityRepository SiteIdentity { get; }
        IMessagesRepository Messages { get; }
        IInterestsRepository Interests { get; }
        IHomePageSlidersRepository HomePageSliders { get; }
        IExperiencesRepository Experiences { get; }
        IEducationRepository Education { get; }
        IContactInfoRepository Contact { get; }
        ICommentRepository Comment { get; }
        ICategoriesRepository Categories { get; }
        IArticleRepository Article { get; }
        IAboutMeRepository AboutMe { get; }
        IAdminRepository Admin { get; }
        Task<int> SaveAsync();
    }
}
