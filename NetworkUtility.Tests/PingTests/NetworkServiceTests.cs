using FluentAssertions;
using NetworkUtility.Ping;

namespace NetworkUtility.Tests.PingTests;

public class NetworkServiceTests
{
    [Fact]
    public async Task NetworkService_SendPingAsync_Returns_Success()
    {
        // Arrange
        var networkService = new NetworkService();

        // Act
        var result = await networkService.SendPingAsync();

        // Assert
        //Assert.Equal("Success: Ping Sent!", result);
        result.Should().Be("Success: Ping Sent!");
        result.Should().NotBeNullOrWhiteSpace();
        result.Should().Contain("Success", Exactly.Once());
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 3, 5)]
    [InlineData(3, 4, 7)]
    public async Task NetworkService_PingTimeOut_Returns_Sum(int a, int b, int expected)
    {
        // Arrange
        var networkService = new NetworkService();

        // Act
        var result = await networkService.PingTimeOutAsync(a, b);

        // Assert
        result.Should().Be(expected);
        result.Should().BeGreaterThanOrEqualTo(3);
        result.Should().NotBeInRange(-1000, 0);
    }
}
