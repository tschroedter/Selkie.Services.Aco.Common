using Selkie.Services.Aco.Common.Messages;
using Xunit;

namespace Selkie.Services.Aco.Common.Tests.Messages
{
    public class PheromonesMessageTests
    {
        [Fact]
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