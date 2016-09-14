using System;
using Selkie.Services.Aco.Common.Messages;
using Xunit;

namespace Selkie.Services.Aco.Common.Tests.Messages
{
    public class PheromonesRequestMessageTests
    {
        [Fact]
        public void ColonyId_ReturnsEmpty_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new PheromonesRequestMessage();

            // Assert
            Assert.Equal(Guid.Empty,
                         sut.ColonyId);
        }
    }
}