using System.Linq;
using Selkie.Services.Aco.Common.Messages;
using Xunit;

namespace Selkie.Services.Aco.Common.Tests.Messages
{
    public sealed class BestTrailMessageTests
    {
        [Fact]
        public void PropertyTrailIsNotNullTest()
        {
            // Arrange
            // Act
            var sut = new BestTrailMessage();

            // Assert
            Assert.Equal(0,
                         sut.Trail.Count());
        }

        [Fact]
        public void PropertyTypeIsSetToUnknownTest()
        {
            // Arrange
            // Act
            var sut = new BestTrailMessage();

            // Assert
            Assert.Equal("Unknown",
                         sut.Type);
        }
    }
}