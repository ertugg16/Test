using System;
using System.Collections.Generic;

namespace MyBlog.Models
{
    public partial class VisitorLog
    {
        public int VisitorLogID { get; set; }
        public Nullable<System.DateTime> VisitorLogDate { get; set; }
        public string VisitorIP { get; set; }
        public Nullable<int> VisitorCount { get; set; }
    }
}
