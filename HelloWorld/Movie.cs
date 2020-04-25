using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Movie
    {
        public string director;
        public string title;
        public string rating;

        public Movie(string aDirector, string aTitle, string aRating)
        {
            director = aDirector;
            title = aTitle;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "NR")
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
