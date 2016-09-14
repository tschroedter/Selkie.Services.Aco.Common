using System;
using Selkie.Services.Aco.Common.Messages;
using Xunit;

namespace Selkie.Services.Aco.Common.Tests.Messages
{
    public sealed class CreateColonyMessageTests
    {
        [Fact]
        public void ColonyId_ReturnsNewGuid_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new CreateColonyMessage();

            // Assert
            Assert.NotEqual(Guid.Empty,
                            sut.ColonyId);
        }

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
        public void CostPerFeature_ReturnsDefault_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new CreateColonyMessage();

            // Assert
            Assert.NotNull(sut.CostPerFeature);
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

        [Fact]
        public void IsFixedStartNode_ReturnsDefault_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new CreateColonyMessage();

            // Assert
            Assert.False(sut.IsFixedStartNode);
        }
    }
}