using cloudscribe.Pagination.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MoviesGallery.App.Data
{
    public interface IRepository<T>
        where T : class
    {
        Task<IEnumerable<T>> GetAll();

  
        Task<PagedResult<T>> GetAllInPage(int pageNumber, int pageSize,
            Expression<Func<T, bool>> predicate = null);

        Task<T> GetById(long id); 

        Task Create(T item); 

        Task Update(T item); 

        Task Delete(long id);

        Task<IEnumerable<T>> Filter(Expression<Func<T, bool>> predicate);

    }
}
