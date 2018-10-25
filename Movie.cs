using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
        }
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        private string category;
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        

    }
    
}
