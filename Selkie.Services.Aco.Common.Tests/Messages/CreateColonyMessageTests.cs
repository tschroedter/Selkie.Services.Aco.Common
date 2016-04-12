using Selkie.Services.Aco.Common.Messages;
using Xunit;

namespace Selkie.Services.Aco.Common.Tests.Messages
{
    public sealed class CreateColonyMessageTests
    {
        [Fact]
        public void CostMatrix_ReturnsDefault_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new CreateColonyMessage();

            // Assert
            Assert.NotNull(sut.CostMatrix);
        }

        [Fact]
        public void CostPerLine_ReturnsDefault_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new CreateColonyMessage();

            // Assert
            Assert.NotNull(sut.CostPerLine);
        }

        [Fact]
        public void IsFixedStartNode_ReturnsDefault_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new CreateColonyMessage();

            // Assert
            Assert.False(sut.IsFixedStartNode);
        }

        [Fact]
        public void FixedStartNode_ReturnsDefault_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new CreateColonyMessage();

            // Assert
            Assert.Equal(0,
                         sut.FixedStartNode);
        }
    }
}