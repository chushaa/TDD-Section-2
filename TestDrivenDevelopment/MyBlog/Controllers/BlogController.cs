using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlog;

namespace MyBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly List<Post> posts;

        public BlogController(List<Post> post)
        {
            posts = post;
        }

        public ActionResult<List<Post>> Get()
        {
            return posts.ToList();
        }
    }
}