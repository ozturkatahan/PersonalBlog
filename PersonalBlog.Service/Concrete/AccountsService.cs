using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Service.Dtos.AccountsDtos;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Concrete
{
    public class AccountsService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        private readonly IMapper _mapper;
        public async Task<IDataResult<AccountsDto>> Add(AccountsAddDto accountssAddDto)
        {
            if (accountssAddDto != null)
            {
                var account = _mapper.Map<SocialMediaAccounts>(accountssAddDto);
                await _unitOfWork.SocialMediaAccounts.AddAsync(account);
                await _unitOfWork.SaveAsync();
                return new DataResult<AccountsDto>(ResultStatus.Success, new AccountsDto { SocialMediaAccounts = account });
            }

            return new DataResult<AccountsDto>(ResultStatus.Error, "Hata. Girdiğiniz bilgileri kontrol ediniz.", null);

        }

        public async Task<IResult> Delete(int id)
        {
            var account = await _unitOfWork.SocialMediaAccounts.GetAsync(x => x.Id == id);
            if (account != null)
            {
                account.IsDeleted = true;
                await _unitOfWork.SocialMediaAccounts.UpdateAsync(account);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Hata. Kayıt bulunamadı.");
        }

        public async Task<IDataResult<AccountsDto>> Get(int id)
        {
            var account = await _unitOfWork.SocialMediaAccounts.GetAsync(x => x.Id == id);
            if (account != null)
            {
                return new DataResult<AccountsDto>(ResultStatus.Success, new AccountsDto { SocialMediaAccounts = account });
            }
            return new DataResult<AccountsDto>(ResultStatus.Error, "Hata. Kayıt bulunamadı.", null);
        }

        public async Task<IDataResult<AccountListDto>> GetAll()
        {
            var accounts = await _unitOfWork.SocialMediaAccounts.GetAllAsync();
            if (accounts.Count > 0)
            {
                return new DataResult<AccountListDto>(ResultStatus.Success, new AccountListDto { SocialMediaAccounts = accounts });
            }
            return new DataResult<AccountListDto>(ResultStatus.Error, "Hata. Kayıtlar bulunamadı.", null);
        }

        public async Task<IDataResult<AccountListDto>> GetAllByNonDelete()
        {
            var accounts = await _unitOfWork.SocialMediaAccounts.GetAllAsync(x => x.IsDeleted == false);
            if (accounts.Count > 0)
            {
                return new DataResult<AccountListDto>(ResultStatus.Success, new AccountListDto { SocialMediaAccounts = accounts });
            }
            return new DataResult<AccountListDto>(ResultStatus.Error, "Hata. Kayıtlar bulunamadı.", null);
        }

        public async Task<IDataResult<AccountListDto>> GetAllByNonDeleteAndActive()
        {
            var accounts = await _unitOfWork.SocialMediaAccounts.GetAllAsync(x => x.IsDeleted == false && x.IsActive == true);
            if (accounts.Count > 0)
            {
                return new DataResult<AccountListDto>(ResultStatus.Success, new AccountListDto { SocialMediaAccounts = accounts });
            }
            return new DataResult<AccountListDto>(ResultStatus.Error, "Hata. Kayıtlar bulunamadı.", null);
        }

        public async Task<IResult> HardDelete(int id)
        {
            var account = await _unitOfWork.SocialMediaAccounts.GetAsync(x => x.Id == id);
            if (account != null)
            {
                await _unitOfWork.SocialMediaAccounts.DeleteAsync(account);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Hata. Kayıt bulunamadı.");
        }

        public async Task<IDataResult<AccountsDto>> Update(AccountsUpdateDto accountsUpdateDto)
        {
            if (accountsUpdateDto != null)
            {
                var account = _mapper.Map<SocialMediaAccounts>(accountsUpdateDto);
                account.ModifiedTime = DateTime.Now;
                await _unitOfWork.SocialMediaAccounts.UpdateAsync(account);
                await _unitOfWork.SaveAsync();
                return new DataResult<AccountsDto>(ResultStatus.Success, new AccountsDto { SocialMediaAccounts = account });
            }
            return new DataResult<AccountsDto>(ResultStatus.Error, "Hata. Girdiğiniz bilgileri kontrol ediniz.", null);
        }
    }
}
