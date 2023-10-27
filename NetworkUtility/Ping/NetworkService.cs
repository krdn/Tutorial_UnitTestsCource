using System.Net.NetworkInformation;

namespace NetworkUtility.Ping;
public class NetworkService
{
    public Task<string> SendPingAsync()
    {

        //var ping = new System.Net.NetworkInformation.Ping();
        //var reply = await ping.SendPingAsync(hostNameOrAddress);
        //return reply.Status == IPStatus.Success;

        return Task.FromResult("Success: Ping Sent!");

    }

    public Task<int> PingTimeOutAsync(int a, int b)
    {
        return Task.FromResult(a + b);
    }

    public Task<DateTime> LastPingDateAsync()
    {
        return Task.FromResult(DateTime.Now);
    }

    public PingOptions GetPingOptions()
    {
        return new PingOptions() {
            DontFragment = true,
            Ttl = 1
        };
    }

    public IEnumerable<PingOptions> MostRecentPings()
    {
        return new List<PingOptions>()
        {
            new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            },
            new PingOptions()
            {
                DontFragment = true,
                Ttl = 2
            },
            new PingOptions()
            {
                DontFragment = true,
                Ttl = 3
            }
        };

    
    }
}
