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
        private readonly List<Post> _posts;
        public BlogController(List<Post> posts)
        {
            _posts = posts;
        }

        public ActionResult<List<Post>> Get()
        {
            return _posts.ToList();
        }
    }
}