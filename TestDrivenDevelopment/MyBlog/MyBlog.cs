using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog
{

    public class Post
    {
        public string Title { get; set; }

        public Guid Id { get; set; }

        public string Content { get; set; }
    }
}
