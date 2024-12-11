using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SocialNetwork.Database;
using SocialNetwork.Services.Services;
using SocialNetwork.Services.Services.Contracts;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.ServicesTests.PostServiceTests
{
    [TestClass]
    public class GetPostByIdAsync_Should
    {
        [TestMethod]
        public async Task ReturnCorrectPost()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(ReturnCorrectPost));
            var config = Utils.GetMappingConfig();
            var mapper = config.CreateMapper();
            var azureBlobService = Mock.Of<IBlobService>();

            var posts = Utils.GetPosts();
            var users = Utils.GetUsers();
            var post = posts.First();

            using (var arrangeContext = new SocialNetworkDBContext(options))
            {                
                await arrangeContext.Posts.AddRangeAsync(posts);
                await arrangeContext.Users.AddRangeAsync(users);
                await arrangeContext.SaveChangesAsync();
            }

            //Act & Assert
            using (var actContext = new SocialNetworkDBContext(options))
            {
                var sut = new PostService(actContext, azureBlobService, mapper);
                var result = await sut.GetPostByIdAsync(post.Id);

                Assert.AreEqual(post.Id, result.Id);
            }
        }

        [TestMethod]
        public async Task ThrowWhen_InvalidParams()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(ThrowWhen_InvalidParams));
            var config = Utils.GetMappingConfig();
            var mapper = config.CreateMapper();
            var azureBlobService = Mock.Of<IBlobService>();

            //Act & Assert
            using (var actContext = new SocialNetworkDBContext(options))
            {
                var sut = new PostService(actContext, azureBlobService, mapper);

                await Assert.ThrowsExceptionAsync<ArgumentException>
                    (async () => await sut.GetPostByIdAsync(1));
            }
        }
    }
}
