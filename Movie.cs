namespace Giraffe
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string mTitle, string mDirector, string mRating)
        {
            title = mTitle;
            director = mDirector;
            Rating = mRating;
        }
        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}