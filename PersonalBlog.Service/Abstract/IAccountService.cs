using PersonalBlog.Service.Dtos.AccountsDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public interface IAccountService
    {
        Task<IDataResult<AccountsDto>> Get(int id);
        Task<IDataResult<AccountListDto>> GetAll();
        Task<IDataResult<AccountListDto>> GetAllByNonDelete();
        Task<IDataResult<AccountListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<AccountsDto>> Add(AccountsAddDto accountssAddDto);
        Task<IDataResult<AccountsDto>> Update(AccountsUpdateDto accountsUpdateDto);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
