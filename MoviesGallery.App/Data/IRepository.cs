using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesGallery.App.Data
{
    public interface IRepository<T>
        where T : class
    {
        Task<IEnumerable<T>> GetAll(); 

        Task<T> GetById(long id); 

        void Create(T item); 

        void Update(T item); 

        void Delete(long id);

        Task<IEnumerable<T>> Filter(Func<T, bool> predicate);
    }
}
