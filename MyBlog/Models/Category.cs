using System;
using System.Collections.Generic;

namespace MyBlog.Models
{
    public partial class Category
    {
        public Category()
        {
            this.Articles = new List<Article>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
