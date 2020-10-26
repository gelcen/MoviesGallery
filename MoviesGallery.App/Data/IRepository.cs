using cloudscribe.Pagination.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesGallery.App.Data
{
    public interface IRepository<T>
        where T : class
    {
        Task<IEnumerable<T>> GetAll(); 

        Task<PagedResult<T>> GetAllInPage(int pageNumber, int pageSize);

        Task<T> GetById(long id); 

        Task Create(T item); 

        Task Update(T item); 

        Task Delete(long id);

        Task<IEnumerable<T>> Filter(Func<T, bool> predicate);

    }
}
