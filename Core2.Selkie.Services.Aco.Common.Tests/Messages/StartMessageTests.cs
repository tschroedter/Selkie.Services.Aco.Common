using System;
using Core2.Selkie.Services.Aco.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Aco.Common.Tests.Messages
{
    [TestFixture]
    internal sealed class StartMessageTests
    {
        [Test]
        public void ColonyId_ReturnsEmpty_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new StartMessage();

            // Assert
            Assert.AreEqual(Guid.Empty,
                            sut.ColonyId);
        }

        [Test]
        public void CostMatrix_ReturnsDefault_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new StartMessage
                      {
                          Times = 123
                      };

            // Assert
            Assert.AreEqual(123,
                            sut.Times);
        }
    }
}