using System;
using System.Collections.Generic;

namespace MyBlog.Models
{
    public partial class Picture
    {
        public Picture()
        {
            this.Articles = new List<Article>();
            this.Authors = new List<Author>();
            this.Articles1 = new List<Article>();
        }

        public int PictureID { get; set; }
        public string PictureName { get; set; }
        public System.Guid PictureAddingAuthor { get; set; }
        public System.DateTime PictureAddDate { get; set; }
        public int PictureOpening { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<Article> Articles1 { get; set; }
    }
}
