using System;
using System.Collections.Generic;

namespace MyBlog.Models
{
    public partial class Article
    {
        public Article()
        {
            this.Comments = new List<Comment>();
            this.Tags = new List<Tag>();
            this.Pictures = new List<Picture>();
        }

        public int ArticleID { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public System.DateTime ArticleReleaseDate { get; set; }
        public int ArticleCategoryID { get; set; }
        public System.Guid ArticleAuthorID { get; set; }
        public int ArticleCoverPictureID { get; set; }
        public int ArticleOpening { get; set; }
        public int ArticleLike { get; set; }
        public bool ArticleActive { get; set; }
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual Picture Picture { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
