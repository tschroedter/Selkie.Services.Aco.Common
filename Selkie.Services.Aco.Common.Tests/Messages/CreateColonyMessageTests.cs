using System;
using Core2.Selkie.Services.Aco.Common.Messages;

namespace Core2.Selkie.Services.Aco.Common.Tests.Messages
{
    public sealed class CreateColonyMessageTests
    {
        [Test]
        public void ColonyId_ReturnsNewGuid_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new CreateColonyMessage();

            // Assert
            Assert.NotEqual(Guid.Empty,
                            sut.ColonyId);
        }

        [Test]
        public void CostMatrix_ReturnsDefault_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new CreateColonyMessage();

            // Assert
            Assert.NotNull(sut.CostMatrix);
        }

        [Test]
        public void CostPerFeature_ReturnsDefault_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new CreateColonyMessage();

            // Assert
            Assert.NotNull(sut.CostPerFeature);
        }

        [Test]
        public void FixedStartNode_ReturnsDefault_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new CreateColonyMessage();

            // Assert
            Assert.Equal(0,
                         sut.FixedStartNode);
        }

        [Test]
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