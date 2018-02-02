using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public enum Categories { scifi = 1, horror, animated, action };

    class Movie
    {
        #region Fields
        private string title;
        private string category;
        #endregion

        #region Properties
        public string Title
        {
            set { title = value; }
            get { return title; }
        }
        public string Category
        {
            set { category = value; }
            get { return category; }
        }
        #endregion

        #region Constructors
        public Movie(string MovieName, string MovieGen)
        {
            title = MovieName;
            category = MovieGen;
        }
        #endregion
    }
}
