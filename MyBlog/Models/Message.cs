using System;
using System.Collections.Generic;

namespace MyBlog.Models
{
    public partial class Message
    {
        public int MessageID { get; set; }
        public System.DateTime MessageSendDate { get; set; }
        public string MesageDescription { get; set; }
        public string MessageEmail { get; set; }
    }
}
