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
        private readonly BlogController _blogController;
        private Mock<List<Post>> _mockPostsList;

        public BlogTest()
        {
            _mockPostsList = new Mock<List<Post>>();
            _blogController = new BlogController(_mockPostsList.Object);
        }

        [Fact]
        public void GetTest_ReturnsListsOfPosts()
        {
            var mockPosts = new List<Post>
            {
                new Post { Title = "TDD One" },
                new Post { Title = "TDD Two" }
            };
            _mockPostsList.Object.AddRange(mockPosts);

            var result = _blogController.Get();

            var model = Assert.IsAssignableFrom<ActionResult<List<Post>>>(result);
        }
    }
}
