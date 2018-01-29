using System;
using System.Linq;
using Core2.Selkie.Services.Aco.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Aco.Common.Tests.Messages
{
    [TestFixture]
    internal sealed class BestTrailMessageTests
    {
        [Test]
        public void ColonyId_ReturnsNewGuid_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new BestTrailMessage();

            // Assert
            Assert.AreEqual(Guid.Empty,
                            sut.ColonyId);
        }

        [Test]
        public void PropertyTrailIsNotNullTest()
        {
            // Arrange
            // Act
            var sut = new BestTrailMessage();

            // Assert
            Assert.AreEqual(0,
                            sut.Trail.Count());
        }

        [Test]
        public void PropertyTypeIsSetToUnknownTest()
        {
            // Arrange
            // Act
            var sut = new BestTrailMessage();

            // Assert
            Assert.AreEqual("Unknown",
                            sut.Type);
        }
    }
}