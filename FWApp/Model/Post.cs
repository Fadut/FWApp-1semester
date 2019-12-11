﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWApp.Model
{
    class Post
    {
        private string _postHeadline;
        private string _postText;
        private string _postDate;
        private string _postLink;

        public Post(string postHeadline, string postText, string postDate, string postLink)
        {
            _postHeadline = postHeadline;
            _postText = postText;
            _postDate = postDate;
            _postLink = postLink;
        }

        public string PostHeadline
        {
            get { return _postHeadline; }
            set { _postHeadline = value; }
        }

        public string PostText
        {
            get { return _postText; }
            set { _postText = value; }
        }

        public string PostDate
        {
            get { return _postDate; }
            set { _postDate = value; }
        }

        public string PostLink
        {
            get { return _postLink; }
            set { _postLink = value; }
        }
    }
}
