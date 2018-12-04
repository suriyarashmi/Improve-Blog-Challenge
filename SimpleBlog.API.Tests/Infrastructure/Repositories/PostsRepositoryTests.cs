using SimpleBlog.API.Infrastructure;
using FakeItEasy;
using Xunit;
using SimpleBlog.API.Controllers;
using SimpleBlog.API.Models;

namespace SimpleBlog.API.Tests
{
    public class PostsRepositoryTests
    {
        protected IPostsRepository FakePostsRepository;
        protected PostsController FakePostsController;

        [Fact]
        public void PostsRepository_CallsClient_WhenGetIsInvoked()
        {
            //  Arrange
            FakePostsRepository = A.Fake<IPostsRepository>();
            FakePostsController = new PostsController(FakePostsRepository);

            //  Act
            FakePostsController.Get();

            //  Assert
            A.CallTo(() => FakePostsRepository.GetN<Post>(100)).MustHaveHappenedOnceExactly();
        }
    }
}
