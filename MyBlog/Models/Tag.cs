using System;
using System.Collections.Generic;

namespace MyBlog.Models
{
    public partial class Tag
    {
        public Tag()
        {
            this.Articles = new List<Article>();
        }

        public int TagID { get; set; }
        public string TagName { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
