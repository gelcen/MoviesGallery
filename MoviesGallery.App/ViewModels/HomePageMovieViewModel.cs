namespace MoviesGallery.App.ViewModels
{
    public class HomePageMovieViewModel
    {
        private readonly string _description;

        public HomePageMovieViewModel(long id, string title, string desc)
        {
            Id = id;
            Title = title;
            _description = desc;
        }

        public long Id { get; }

        public string Title { get; }

        public string Description { get => GetShortDescription(); }

        private string GetShortDescription()
        {
            string result = "";

            int firstDot = _description
                    .IndexOf(". ", 0, _description.Length);
            if (firstDot == -1)
                return _description;

            firstDot++;
            result += _description.Substring(0, firstDot);

            int secondDot = _description
                .IndexOf('.', firstDot);
            if (secondDot == -1)
                return result;

            secondDot++;
            result += _description.Substring(firstDot, secondDot - firstDot);

            return result;
        }
    }
}
