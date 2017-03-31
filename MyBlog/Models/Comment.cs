using System;
using System.Collections.Generic;

namespace MyBlog.Models
{
    public partial class Comment
    {
        public int CommentID { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public int CommentArticleID { get; set; }
        public System.DateTime CommentDate { get; set; }
        public virtual Article Article { get; set; }
    }
}
