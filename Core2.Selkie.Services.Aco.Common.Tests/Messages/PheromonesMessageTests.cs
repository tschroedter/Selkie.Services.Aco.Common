using System;
using Core2.Selkie.Services.Aco.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Aco.Common.Tests.Messages
{
    [TestFixture]
    internal sealed class PheromonesMessageTests
    {
        [Test]
        public void ColonyId_ReturnsEmpty_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new PheromonesMessage();

            // Assert
            Assert.AreEqual(Guid.Empty,
                            sut.ColonyId);
        }

        [Test]
        public void PropertyValuesIsNotNullTest()
        {
            // Arrange
            // Act
            var sut = new PheromonesMessage();

            // Assert
            Assert.NotNull(sut.Values);
        }
    }
}