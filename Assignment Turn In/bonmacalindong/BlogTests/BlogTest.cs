using Microsoft.AspNetCore.Mvc;
using Moq;
using MyBlog;
using MyBlog.Controllers;
using System.Collections.Generic;
using Xunit;

namespace BlogTests
{
    public class BlogTest
    {
        BlogController _controller;
        private Mock<List<Post>> _mockPosts;

        public BlogTest()
        {
            _mockPosts = new Mock<List<Post>>();
            _controller = new BlogController(_mockPosts.Object);
        }

        [Fact]
        public void GetTest_ReturnsListsOfPosts()
        {
            // Arrange
            var postsMock = new List<Post>
            {
                new Post
                {
                    Title = "TDD One"
                },
                new Post
                {
                    Title = "TDD and BDD"
                }
            };

            _mockPosts.Object.AddRange(postsMock);

            // Act
            var result = _controller.Get();

            // Assert
            Assert.IsAssignableFrom<ActionResult<List<Post>>>(result);
        }
    }
}
