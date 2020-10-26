using cloudscribe.Pagination.Models;
using MoviesGallery.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MoviesGallery.App.Data
{
    public class MockRepository : IRepository<Movie>
    {
        private List<Movie> _data = new List<Movie>
        {
    new Movie{ Title = "Nullam", Description = "ligula. Aenean euismod mauris eu elit. Nulla facilisi. Sed neque. Sed eget lacus. Mauris non dui nec urna suscipit nonummy. Fusce fermentum fermentum", ReleaseYear = 2056, Director = "Abra G. Coleman" },
    new Movie{ Title = "sed tortor. Integer", Description = "dui nec urna suscipit nonummy. Fusce fermentum fermentum arcu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Phasellus ornare. Fusce", ReleaseYear = 2082, Director = "Jordan W. Nolan" },
    new Movie{ Title = "elit", Description = "aliquet, sem ut cursus luctus, ipsum leo elementum sem, vitae aliquam eros turpis non enim. Mauris quis turpis vitae purus gravida sagittis. Duis", ReleaseYear = 1986, Director = "Caesar T. Whitney" },
    new Movie{ Title = "ipsum", Description = "at pretium aliquet, metus urna convallis erat, eget tincidunt dui augue eu tellus. Phasellus elit pede, malesuada vel, venenatis vel, faucibus id, libero. Donec consectetuer mauris id sapien. Cras", ReleaseYear = 2076, Director = "Miranda D. Solis" },
    new Movie{ Title = "velit.", Description = "Suspendisse sed dolor. Fusce mi lorem, vehicula et, rutrum eu, ultrices sit amet, risus. Donec nibh enim, gravida sit amet, dapibus id, blandit at, nisi. Cum", ReleaseYear = 2064, Director = "Wing K. Garrison" },
    new Movie{ Title = "ac libero", Description = "lobortis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos hymenaeos. Mauris ut quam vel sapien imperdiet ornare. In faucibus. Morbi vehicula. Pellentesque tincidunt tempus risus. Donec egestas. Duis ac arcu.", ReleaseYear = 2034, Director = "Dale D. Montgomery" },
    new Movie{ Title = "malesuada malesuada. Integer", Description = "ut erat. Sed nunc est, mollis non, cursus non, egestas a, dui. Cras pellentesque. Sed dictum. Proin eget odio. Aliquam vulputate", ReleaseYear = 2094, Director = "Oscar G. Hampton" },
    new Movie{ Title = "vel nisl.", Description = "Nunc laoreet lectus quis massa. Mauris vestibulum, neque sed dictum eleifend, nunc risus varius orci, in consequat enim diam vel arcu. Curabitur ut odio vel est tempor bibendum. Donec felis orci, adipiscing non, luctus sit amet, faucibus ut, nulla.", ReleaseYear = 1971, Director = "Erasmus X. Dalton" },
    new Movie{ Title = "ultrices.", Description = "turpis. Nulla aliquet. Proin velit. Sed malesuada augue ut lacus. Nulla tincidunt, neque vitae semper egestas, urna justo faucibus lectus, a sollicitudin orci sem eget massa. Suspendisse eleifend. Cras sed leo. Cras vehicula aliquet libero. Integer in magna. Phasellus", ReleaseYear = 2071, Director = "Kyle X. Washington" },
    new Movie{ Title = "Sed eu nibh", Description = "sagittis. Duis gravida. Praesent eu nulla at sem molestie sodales. Mauris blandit enim consequat purus. Maecenas libero est, congue a, aliquet vel, vulputate eu, odio. Phasellus at augue id", ReleaseYear = 2064, Director = "Avye H. Graham" },
    new Movie{ Title = "ligula eu enim.", Description = "Curabitur vel lectus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec dignissim magna a tortor. Nunc commodo auctor velit. Aliquam nisl. Nulla", ReleaseYear = 2089, Director = "Zeph L. Miller" },
    new Movie{ Title = "egestas", Description = "dolor, nonummy ac, feugiat non, lobortis quis, pede. Suspendisse dui. Fusce diam nunc, ullamcorper eu, euismod ac, fermentum vel, mauris. Integer sem elit, pharetra ut,", ReleaseYear = 1972, Director = "Drake T. Walls" },
    new Movie{ Title = "in faucibus orci", Description = "Morbi quis urna. Nunc quis arcu vel quam dignissim pharetra. Nam ac nulla. In tincidunt congue turpis. In condimentum. Donec", ReleaseYear = 1966, Director = "Jeremy F. Luna" },
    new Movie{ Title = "fermentum", Description = "auctor. Mauris vel turpis. Aliquam adipiscing lobortis risus. In mi pede, nonummy ut, molestie in, tempus eu, ligula. Aenean euismod mauris eu elit. Nulla facilisi. Sed neque. Sed eget lacus. Mauris non dui nec urna suscipit nonummy. Fusce fermentum fermentum", ReleaseYear = 2062, Director = "Gray T. Justice" },
    new Movie{ Title = "Proin vel arcu", Description = "lectus justo eu arcu. Morbi sit amet massa. Quisque porttitor eros nec tellus. Nunc lectus pede, ultrices a, auctor non, feugiat nec, diam.", ReleaseYear = 2024, Director = "Martha P. Bauer" },
    new Movie{ Title = "dolor.", Description = "ullamcorper eu, euismod ac, fermentum vel, mauris. Integer sem elit, pharetra ut, pharetra sed, hendrerit a, arcu. Sed et libero. Proin mi. Aliquam gravida mauris ut mi.", ReleaseYear = 1941, Director = "Blaze N. Good" },
    new Movie{ Title = "Aliquam gravida mauris", Description = "mus. Proin vel nisl. Quisque fringilla euismod enim. Etiam gravida molestie arcu. Sed eu nibh vulputate mauris sagittis placerat. Cras dictum ultricies ligula. Nullam enim. Sed nulla ante, iaculis nec, eleifend", ReleaseYear = 2017, Director = "Vladimir F. Sheppard" },
    new Movie{ Title = "lectus quis massa.", Description = "mi, ac mattis velit justo nec ante. Maecenas mi felis, adipiscing fringilla, porttitor vulputate, posuere vulputate, lacus. Cras interdum. Nunc sollicitudin commodo ipsum. Suspendisse non leo. Vivamus nibh dolor, nonummy ac,", ReleaseYear = 1969, Director = "Ferris I. Howell" },
    new Movie{ Title = "sollicitudin", Description = "Suspendisse tristique neque venenatis lacus. Etiam bibendum fermentum metus. Aenean sed pede nec ante blandit viverra. Donec tempus, lorem fringilla ornare placerat, orci", ReleaseYear = 1946, Director = "Bell N. Russo" },
    new Movie{ Title = "Donec", Description = "ligula elit, pretium et, rutrum non, hendrerit id, ante. Nunc mauris sapien, cursus in, hendrerit consectetuer, cursus et, magna. Praesent interdum ligula eu enim. Etiam imperdiet dictum", ReleaseYear = 1967, Director = "Rae G. Ferguson" },
    new Movie{ Title = "iaculis aliquet", Description = "Pellentesque ultricies dignissim lacus. Aliquam rutrum lorem ac risus. Morbi metus. Vivamus euismod urna. Nullam lobortis quam a felis ullamcorper viverra. Maecenas iaculis aliquet diam. Sed diam lorem, auctor", ReleaseYear = 2067, Director = "Yolanda V. Lyons" },
    new Movie{ Title = "arcu. Nunc", Description = "Etiam vestibulum massa rutrum magna. Cras convallis convallis dolor. Quisque tincidunt pede ac urna. Ut tincidunt vehicula risus. Nulla eget metus eu erat semper rutrum. Fusce dolor quam, elementum at, egestas a,", ReleaseYear = 1961, Director = "Mechelle J. Branch" },
    new Movie{ Title = "velit eget laoreet", Description = "quis arcu vel quam dignissim pharetra. Nam ac nulla. In tincidunt congue turpis. In condimentum. Donec at arcu. Vestibulum ante ipsum primis in faucibus orci luctus", ReleaseYear = 2038, Director = "Hadassah O. Dean" },
    new Movie{ Title = "Sed", Description = "nunc sed pede. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Proin vel arcu eu odio tristique pharetra. Quisque ac libero nec ligula consectetuer rhoncus. Nullam velit", ReleaseYear = 2030, Director = "Kiara E. Gibbs" },
    new Movie{ Title = "facilisis eget,", Description = "arcu. Sed eu nibh vulputate mauris sagittis placerat. Cras dictum ultricies ligula. Nullam enim. Sed nulla ante, iaculis nec, eleifend non, dapibus rutrum,", ReleaseYear = 1913, Director = "Hashim M. Roberts" },
    new Movie{ Title = "sapien, gravida non,", Description = "risus. Morbi metus. Vivamus euismod urna. Nullam lobortis quam a felis ullamcorper viverra. Maecenas iaculis aliquet diam. Sed diam lorem, auctor quis, tristique ac, eleifend vitae, erat. Vivamus nisi. Mauris nulla. Integer urna. Vivamus molestie dapibus", ReleaseYear = 1926, Director = "Jade F. Huff" },
    new Movie{ Title = "hendrerit id, ante.", Description = "dictum. Phasellus in felis. Nulla tempor augue ac ipsum. Phasellus vitae mauris sit amet lorem semper auctor. Mauris vel turpis. Aliquam adipiscing lobortis risus. In mi pede, nonummy ut,", ReleaseYear = 2042, Director = "Keegan A. Horne" },
    new Movie{ Title = "erat nonummy ultricies", Description = "Donec nibh. Quisque nonummy ipsum non arcu. Vivamus sit amet risus. Donec egestas. Aliquam nec enim. Nunc ut erat. Sed nunc est, mollis non, cursus non, egestas a, dui. Cras pellentesque. Sed dictum. Proin", ReleaseYear = 1991, Director = "Kylie P. Ferguson" },
    new Movie{ Title = "aliquam iaculis,", Description = "eu erat semper rutrum. Fusce dolor quam, elementum at, egestas a, scelerisque sed, sapien. Nunc pulvinar arcu et pede. Nunc sed orci lobortis augue scelerisque mollis. Phasellus libero mauris, aliquam eu, accumsan sed, facilisis vitae, orci. Phasellus", ReleaseYear = 2053, Director = "Zena C. Duncan" },
    new Movie{ Title = "elementum", Description = "Fusce mi lorem, vehicula et, rutrum eu, ultrices sit amet, risus. Donec nibh enim, gravida sit amet, dapibus id, blandit at, nisi. Cum sociis natoque", ReleaseYear = 1946, Director = "Harding C. Cantrell" },
    new Movie{ Title = "turpis vitae purus", Description = "vehicula risus. Nulla eget metus eu erat semper rutrum. Fusce dolor quam, elementum at, egestas a, scelerisque sed, sapien. Nunc pulvinar arcu et pede. Nunc sed orci lobortis augue scelerisque mollis. Phasellus libero mauris, aliquam eu, accumsan", ReleaseYear = 2050, Director = "Aladdin X. Bailey" },
    new Movie{ Title = "Suspendisse aliquet, sem", Description = "malesuada fames ac turpis egestas. Aliquam fringilla cursus purus. Nullam scelerisque neque sed sem egestas blandit. Nam nulla magna, malesuada vel, convallis in, cursus et, eros. Proin ultrices.", ReleaseYear = 1991, Director = "Brenden Q. Lloyd" },
    new Movie{ Title = "augue", Description = "amet, risus. Donec nibh enim, gravida sit amet, dapibus id, blandit at, nisi. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur", ReleaseYear = 2075, Director = "Breanna E. Bruce" },
    new Movie{ Title = "ad litora", Description = "vitae sodales nisi magna sed dui. Fusce aliquam, enim nec tempus scelerisque, lorem ipsum sodales purus, in molestie tortor nibh sit amet orci. Ut sagittis lobortis mauris. Suspendisse aliquet molestie tellus. Aenean egestas hendrerit neque. In", ReleaseYear = 2063, Director = "Caesar J. Cooley" },
        };

        public MockRepository()
        {
            int day = 0;
            foreach (var item in _data)
            {
                item.Id = day;
                item.Title = char.ToUpper(item.Title[0]) + item.Title.Substring(1);
                item.Description = char.ToUpper(item.Description[0]) +
                    item.Description.Substring(1);
                item.AddDate = DateTime.Now;
                item.AddDate = item.AddDate.AddDays(day);
                day++;
            }
        }

        public async Task Create(Movie item)
        {
            int id = _data.Count + 1;
            item.Id = id;
            _data.Add(item);

            await Task.FromResult(id);
        }

        public async Task Delete(long id)
        {
            var movie = await GetById(id);
            _data.Remove(movie);
        }

        public Task<IEnumerable<Movie>> Filter(Func<Movie, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> Filter(Expression<Func<Movie, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetAll()
        {
            return Task.FromResult<IEnumerable<Movie>>(_data.OrderByDescending(m => m.AddDate));
        }

        public Task<PagedResult<Movie>> GetAllInPage(int pageNumber, int pageSize)
        {
            int excludeRecords = (pageSize * pageNumber) - pageSize;

            var query = _data
                .OrderByDescending(m => m.AddDate)
                .Skip(excludeRecords)
                .Take(pageSize);

            //    var query = db.EmailLists.OrderBy(x => x.Title)
            //.Select(p => p)
            //.Skip(offset)
            //.Take(pageSize)
            //;

            //    var result = new PagedResult<EmailList>();
            //    result.Data = await query.AsNoTracking().ToListAsync(cancellationToken);
            //    result.TotalItems = await db.EmailLists.CountAsync();
            //    result.PageNumber = pageNumber;
            //    result.PageSize = pageSize;

            var result = new PagedResult<Movie>
            {
                Data = query.ToList(),
                TotalItems = _data.Count,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return Task.FromResult(
                result
                );
        }

        public Task<Movie> GetById(long id)
        {
            return Task.FromResult(
                _data.FirstOrDefault(m => m.Id == id)
                );
        }

        public async Task Update(Movie item)
        {
            var old = await GetById(item.Id);
            old.Title = item.Title;
            old.Director = item.Director;
            old.ReleaseYear = item.ReleaseYear;
            old.Description = item.Description;
        }
    }
}
