using Selkie.Services.Aco.Common.Messages;
using Xunit;

namespace Selkie.Services.Aco.Common.Tests.Messages
{
    public sealed class CreateColonyMessageTests
    {
        [Fact]
        public void PropertyCostMatrixIsNotNullTest()
        {
            // Arrange
            // Act
            var sut = new CreateColonyMessage();

            // Assert
            Assert.NotNull(sut.CostMatrix);
        }

        [Fact]
        public void PropertyCostPerLineIsNotNullTest()
        {
            // Arrange
            // Act
            var sut = new CreateColonyMessage();

            // Assert
            Assert.NotNull(sut.CostPerLine);
        }
    }
}