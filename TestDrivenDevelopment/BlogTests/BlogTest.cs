using System;
using System.Collections.Generic;
using Moq;
using Xunit;
using MyBlog;
using MyBlog.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace BlogTests
{
    public class BlogTest
    {
        private readonly BlogController blogController;
        private Mock<List<Post>> mockPostsList;

        public BlogTest()
        {
            mockPostsList = new Mock<List<Post>>();
            blogController = new BlogController(mockPostsList.Object);
        }

        [Fact]
        public void GetTest_ReturnsListsOfPosts()
        {
            var mockPosts = new List<Post>
            {
                new Post{Title = "TDD One"},
                new Post{Title = "TDD and BDD"}
            };

            mockPostsList.Object.AddRange(mockPosts);

            var result = blogController.Get();
            var model = Assert.IsAssignableFrom<ActionResult<List<Post>>>(result);
        }
    }
}
