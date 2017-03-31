using System;
using System.Collections.Generic;

namespace MyBlog.Models
{
    public partial class Author
    {
        public Author()
        {
            this.Articles = new List<Article>();
            this.Pictures = new List<Picture>();
        }

        public System.Guid AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string AuthorMail { get; set; }
        public System.DateTime AuthorCreateDate { get; set; }
        public string AuthorNickname { get; set; }
        public int AuthorPictureID { get; set; }
        public bool AuthorActive { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual Picture Picture { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
