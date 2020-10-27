using cloudscribe.Pagination.Models;
using Microsoft.EntityFrameworkCore;
using MoviesGallery.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MoviesGallery.App.Data
{
    public class MoviesRepository : IRepository<Movie>
    {
        private readonly MoviesGalleryContext _ctx;

        public MoviesRepository(MoviesGalleryContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Create(Movie item)
        {
            if (item == null) throw new ArgumentNullException();

            _ctx.Add(item);
            await _ctx.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            _ctx.Movies.Remove(await GetById(id));
            await _ctx.SaveChangesAsync();
        }

        public async Task<IEnumerable<Movie>> Filter(Expression<Func<Movie, bool>> predicate)
        {
            var movies = await _ctx.Movies.Where(predicate).ToListAsync();
            return movies;
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            var movies = await _ctx.Movies.ToListAsync();
            return movies;
        }

        public async Task<PagedResult<Movie>> GetAllInPage(int pageNumber, int pageSize, 
            Expression<Func<Movie, bool>> predicate = null)
        {
            int excludeRecords = (pageSize * pageNumber) - pageSize;

            IQueryable<Movie> query = null;

            if (predicate == null)
            {
                query = _ctx.Movies
                    .OrderByDescending(m => m.AddDate)
                    .Skip(excludeRecords)
                    .Take(pageSize);
            }
            else
            {
                query = _ctx.Movies
                    .Where(predicate)
                    .OrderByDescending(m => m.AddDate)
                    .Skip(excludeRecords)
                    .Take(pageSize);
            }

            PagedResult<Movie> result = null;

            if (predicate == null)
            {
                result = new PagedResult<Movie>
                {
                    Data = await query.AsNoTracking().ToListAsync(),
                    TotalItems = await _ctx.Movies.CountAsync(),
                    PageNumber = pageNumber,
                    PageSize = pageSize
                };
            }
            else
            {
                result = new PagedResult<Movie>
                {
                    Data = await query.AsNoTracking().ToListAsync(),
                    TotalItems = await _ctx.Movies.Where(predicate).CountAsync(),
                    PageNumber = pageNumber,
                    PageSize = pageSize
                };

            }

            return result;
        }

        public async Task<Movie> GetById(long id)
        {
            var movie = await _ctx.Movies.FirstOrDefaultAsync(
                m => m.Id == id);

            if (movie == null)
            {
                throw new ArgumentNullException("Фильм не найден");
            }

            return movie;
        }

        public async Task Update(Movie item)
        {
            if (item == null) throw new ArgumentNullException();

            _ctx.Movies.Update(item);
            await _ctx.SaveChangesAsync();
        }
    }
}
