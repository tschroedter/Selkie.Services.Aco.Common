﻿using System;
using Selkie.Services.Aco.Common.Messages;
using Xunit;

namespace Selkie.Services.Aco.Common.Tests.Messages
{
    public sealed class StartMessageTests
    {
        [Fact]
        public void ColonyId_ReturnsEmpty_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new StartMessage();

            // Assert
            Assert.Equal(Guid.Empty,
                         sut.ColonyId);
        }

        [Fact]
        public void CostMatrix_ReturnsDefault_WhenCalled()
        {
            // Arrange
            // Act
            var sut = new StartMessage
                      {
                          Times = 123
                      };

            // Assert
            Assert.Equal(123,
                         sut.Times);
        }
    }
}