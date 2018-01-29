using System;
using Core2.Selkie.Services.Aco.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Aco.Common.Tests.Messages
{
    [TestFixture]
    internal sealed class StoppedMessageTests
    {
        [Test]
        public void ColonyId_ReturnsEmpty_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new StoppedMessage();

            // Assert
            Assert.AreEqual(Guid.Empty,
                            sut.ColonyId);
        }
    }
}