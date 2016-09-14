using System;
using Selkie.Services.Aco.Common.Messages;
using Xunit;

namespace Selkie.Services.Aco.Common.Tests.Messages
{
    public sealed class StartedMessageTests
    {
        [Fact]
        public void ColonyId_ReturnsEmpty_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new StartedMessage();

            // Assert
            Assert.Equal(Guid.Empty,
                         sut.ColonyId);
        }
    }
}