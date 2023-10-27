using System.Net.NetworkInformation;
using FluentAssertions;
using NetworkUtility.Ping;

namespace NetworkUtility.Tests.PingTests;

public class NetworkServiceTests
{
    private readonly NetworkService _networkService;

    public NetworkServiceTests()
    {
        // SUT(테스트 대상 시스템) : https://kukim.tistory.com/47
        _networkService = new NetworkService();
    }

    [Fact]
    public async Task NetworkService_SendPingAsync_Returns_Success()
    {
        // Arrange

        // Act
        var result = await _networkService.SendPingAsync();

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
    public async Task NetworkService_PingTimeOutAsync_Returns_Sum(int a, int b, int expected)
    {
        // Arrange

        // Act
        var result = await _networkService.PingTimeOutAsync(a, b);

        // Assert
        result.Should().Be(expected);
        result.Should().BeGreaterThanOrEqualTo(3);
        result.Should().NotBeInRange(-1000, 0);
    }

    [Fact]
    public async Task NetworkService_LastPingDateAsync_Returns_DateTimeNow()
    {
        // Arrange

        // Act
        var result = await _networkService.LastPingDateAsync();

        // Assert
        //result.Should().BeCloseTo(DateTime.Now, 1000);
        result.Should().BeAfter(DateTime.Now.AddSeconds(-1));
        result.Should().BeBefore(DateTime.Now.AddSeconds(1));
    }

    [Fact]
    public void NetworkService_GetPingOptions_Returns_PingOptions()
    {
        // Arrange

        // Act
        var result = _networkService.GetPingOptions();

        // Assert
        result.Should().BeOfType<PingOptions>();
        result.Should().NotBeNull();
        result.DontFragment.Should().BeTrue();
        result.Ttl.Should().Be(1);
    }

    [Fact]
    public void NetworkService_MostRecentPings_Returns_PingOptions()
    {
        // Arrange

        // Act
        var result = _networkService.MostRecentPings();

        // Assert
        result.Should().BeOfType<List<PingOptions>>();
        result.Should().NotBeNull();
        result.Should().HaveCount(3);
        result.Should().OnlyHaveUniqueItems();
        result.Should().OnlyContain(x => x.DontFragment == true);
        result.Should().OnlyContain(x => x.Ttl >= 1 && x.Ttl <= 3);
    }
}
