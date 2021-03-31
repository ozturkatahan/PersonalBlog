using PersonalBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T: class, IEntity, new ()
    {
        // Tek bir kaydı çekmeye yarar , Id'ye göre seçmek için -> "Expression<Func<T, bool>> predicate"
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        // Tüm kayıtları çekmeye yarar (liste içinde)
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);
        // Kayıt ekleme
        Task<T> AddAsync(T entity);
        // Kayıt Güncelleme
        Task<T> UpdateAsync(T entity);
        // Kayıt silme
        Task DeleteAsync(T entity);
        // Nesne veritabanında var mı?
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        // Verileri sayma
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
    }
}
