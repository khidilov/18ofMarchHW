using System;
using System.Collections.Generic;
using System.Text;

namespace _18ofMarch_FacebookHW.Models
{
    internal class Post
    {
        public string Text;
        public string PublicationDate;
        public int LikeQ;
        public int CommentQ;
        public Comment[] Comments;
    }
}
