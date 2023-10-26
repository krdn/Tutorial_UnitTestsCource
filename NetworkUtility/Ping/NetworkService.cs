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
}
