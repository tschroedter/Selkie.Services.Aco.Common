using System;
using Core2.Selkie.Services.Aco.Common.Messages;
using NUnit.Framework;

namespace Selkie.Services.Aco.Common.Tests.Messages
{
    [TestFixture]
    internal sealed class StopRequestMessageTests
    {
        [Test]
        public void ColonyId_ReturnsEmpty_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new StopRequestMessage();

            // Assert
            Assert.AreEqual(Guid.Empty,
                            sut.ColonyId);
        }
    }
}