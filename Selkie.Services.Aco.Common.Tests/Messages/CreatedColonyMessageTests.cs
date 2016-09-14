using System;
using Selkie.Services.Aco.Common.Messages;
using Xunit;

namespace Selkie.Services.Aco.Common.Tests.Messages
{
    public sealed class CreatedColonyMessageTests
    {
        [Fact]
        public void ColonyId_ReturnsEmpty_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new CreatedColonyMessage();

            // Assert
            Assert.Equal(Guid.Empty,
                         sut.ColonyId);
        }
    }
}