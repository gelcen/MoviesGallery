using MoviesGallery.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesGallery.App.Data
{
	public class MockRepository : IRepository<Movie>
	{
		private List<Movie> _data = new List<Movie>
		{
			new Movie { Title = "ligula", Description = "nascetur ridiculus mus. Proin vel nisl. Quisque fringilla euismod enim. Etiam gravida molestie arcu. Sed eu nibh vulputate mauris sagittis placerat. Cras dictum ultricies ligula. Nullam enim. Sed nulla ante, iaculis nec,", ReleaseYear = 2072 },
			new Movie { Title = "nec", Description = "ut, molestie in, tempus eu, ligula. Aenean euismod mauris eu elit. Nulla facilisi. Sed neque. Sed eget lacus. Mauris non dui nec urna suscipit nonummy. Fusce fermentum fermentum arcu. Vestibulum ante ipsum", ReleaseYear = 1985 },
			new Movie { Title = "Morbi", Description = "Cras vulputate velit eu sem. Pellentesque ut ipsum ac mi eleifend egestas. Sed pharetra, felis eget varius ultrices, mauris ipsum porta elit, a feugiat tellus lorem eu metus. In lorem. Donec elementum,", ReleaseYear = 1980 },
			new Movie { Title = "sem molestie sodales.", Description = "erat eget ipsum. Suspendisse sagittis. Nullam vitae diam. Proin dolor. Nulla semper tellus id nunc interdum feugiat. Sed nec metus facilisis lorem tristique aliquet. Phasellus fermentum convallis ligula. Donec luctus aliquet odio. Etiam ligula", ReleaseYear = 1921 },
			new Movie { Title = "pede, ultrices a,", Description = "velit. Cras lorem lorem, luctus ut, pellentesque eget, dictum placerat, augue. Sed molestie. Sed id risus quis diam luctus lobortis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos hymenaeos. Mauris", ReleaseYear = 2087 },
			new Movie { Title = "diam", Description = "vestibulum. Mauris magna. Duis dignissim tempor arcu. Vestibulum ut eros non enim commodo hendrerit. Donec porttitor tellus non magna. Nam ligula elit, pretium et, rutrum non, hendrerit id, ante. Nunc mauris sapien, cursus", ReleaseYear = 1907 },
			new Movie { Title = "a, magna. Lorem", Description = "Cras dictum ultricies ligula. Nullam enim. Sed nulla ante, iaculis nec, eleifend non, dapibus rutrum, justo. Praesent luctus. Curabitur egestas nunc sed libero. Proin sed", ReleaseYear = 2002 },
			new Movie { Title = "euismod est arcu", Description = "eu nibh vulputate mauris sagittis placerat. Cras dictum ultricies ligula. Nullam enim. Sed nulla ante, iaculis nec, eleifend non, dapibus rutrum, justo. Praesent", ReleaseYear = 2071 },
			new Movie { Title = "a sollicitudin", Description = "lacus, varius et, euismod et, commodo at, libero. Morbi accumsan laoreet ipsum. Curabitur consequat, lectus sit amet luctus vulputate, nisi sem semper erat, in consectetuer ipsum nunc id enim.", ReleaseYear = 1930 },
			new Movie { Title = "dignissim", Description = "rhoncus id, mollis nec, cursus a, enim. Suspendisse aliquet, sem ut cursus luctus, ipsum leo elementum sem, vitae aliquam eros", ReleaseYear = 1941 },
			new Movie { Title = "auctor,", Description = "Aenean gravida nunc sed pede. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Proin vel arcu eu odio tristique pharetra. Quisque ac libero nec ligula consectetuer rhoncus. Nullam", ReleaseYear = 2014 },
			new Movie { Title = "neque. Nullam", Description = "elementum at, egestas a, scelerisque sed, sapien. Nunc pulvinar arcu et pede. Nunc sed orci lobortis augue scelerisque mollis. Phasellus libero mauris, aliquam eu, accumsan sed,", ReleaseYear = 2006 },
			new Movie { Title = "a tortor. Nunc", Description = "metus facilisis lorem tristique aliquet. Phasellus fermentum convallis ligula. Donec luctus aliquet odio. Etiam ligula tortor, dictum eu, placerat eget, venenatis a, magna. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Etiam laoreet, libero", ReleaseYear = 2026 },
			new Movie { Title = "Aliquam", Description = "libero est, congue a, aliquet vel, vulputate eu, odio. Phasellus at augue id ante dictum cursus. Nunc mauris elit, dictum eu, eleifend nec, malesuada ut, sem. Nulla interdum. Curabitur dictum. Phasellus", ReleaseYear = 2074 },
			new Movie { Title = "arcu. Vestibulum ante", Description = "elit fermentum risus, at fringilla purus mauris a nunc. In at pede. Cras vulputate velit eu sem. Pellentesque ut ipsum ac mi eleifend egestas. Sed pharetra, felis eget", ReleaseYear = 2002 },
			new Movie { Title = "Morbi accumsan laoreet", Description = "Morbi metus. Vivamus euismod urna. Nullam lobortis quam a felis ullamcorper viverra. Maecenas iaculis aliquet diam. Sed diam lorem, auctor quis, tristique ac, eleifend vitae, erat. Vivamus nisi. Mauris nulla. Integer urna. Vivamus", ReleaseYear = 1983 },
			new Movie { Title = "arcu. Morbi", Description = "congue turpis. In condimentum. Donec at arcu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec tincidunt. Donec vitae erat vel pede blandit congue. In", ReleaseYear = 1941 },
			new Movie { Title = "amet", Description = "feugiat nec, diam. Duis mi enim, condimentum eget, volutpat ornare, facilisis eget, ipsum. Donec sollicitudin adipiscing ligula. Aenean gravida nunc sed pede. Cum sociis natoque penatibus et magnis", ReleaseYear = 2045 },
			new Movie { Title = "Sed dictum.", Description = "porttitor eros nec tellus. Nunc lectus pede, ultrices a, auctor non, feugiat nec, diam. Duis mi enim, condimentum eget, volutpat ornare, facilisis eget, ipsum. Donec sollicitudin", ReleaseYear = 2086 },
			new Movie { Title = "Vivamus", Description = "blandit enim consequat purus. Maecenas libero est, congue a, aliquet vel, vulputate eu, odio. Phasellus at augue id ante dictum cursus. Nunc mauris elit,", ReleaseYear = 1981 },
			new Movie { Title = "Phasellus", Description = "netus et malesuada fames ac turpis egestas. Aliquam fringilla cursus purus. Nullam scelerisque neque sed sem egestas blandit. Nam nulla magna, malesuada vel, convallis in, cursus et, eros. Proin ultrices. Duis volutpat nunc sit amet", ReleaseYear = 1948 },
			new Movie { Title = "eu neque pellentesque", Description = "dui nec urna suscipit nonummy. Fusce fermentum fermentum arcu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Phasellus ornare. Fusce mollis.", ReleaseYear = 2067 },
			new Movie { Title = "urna justo", Description = "nec ante blandit viverra. Donec tempus, lorem fringilla ornare placerat, orci lacus vestibulum lorem, sit amet ultricies sem magna nec quam. Curabitur vel lectus. Cum sociis natoque penatibus et magnis", ReleaseYear = 2033 }
		};

        public MockRepository()
        {
            foreach (var item in _data)
            {
				item.Title = char.ToUpper(item.Title[0]) + item.Title.Substring(1);
				item.Description = char.ToUpper(item.Description[0]) + 
					item.Description.Substring(1);
			}
        }

        public void Create(Movie item)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> Filter(Func<Movie, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetAll()
        {
			return Task.FromResult<IEnumerable<Movie>>(_data);
        }

        public Task<Movie> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(Movie item)
        {
            throw new NotImplementedException();
        }
    }
}
