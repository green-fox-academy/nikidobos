using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    class BlogpostClass
    {
        //AuthorName
        //a Title
        //a Text
        //a PublicationDate
        public string authorName;
        public string title;
        public string text;
        public string publicationDate;

        public BlogpostClass(string authorName, string title, string text, string publicationDate)
        {
            this.authorName = authorName;
            this.title = title;
            this.text = text;
            this.publicationDate = publicationDate;
        }
    }
}
