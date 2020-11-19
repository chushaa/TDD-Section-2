using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private List<Post> _posts;
        
        public BlogController(List<Post> posts)
        {
            _posts = posts;
        }

        public ActionResult<List<Post>> Get()
        {
            return _posts;
        }
    }
}