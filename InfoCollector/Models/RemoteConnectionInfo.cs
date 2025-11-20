using Microsoft.Extensions.Primitives;
using System.Net;

namespace InfoCollector.Models
{
    public class RemoteConnectionInfo(
        IPAddress? IPAddress,
        int Port,
        IDictionary<string, StringValues> Headers,
        string Path)
    {
        public IPAddress? IPAddress { get; set; } = IPAddress;
        public int Port { get; set; } = Port;
        public IDictionary<string, StringValues> Headers { get; set; } = Headers;
        public string Path { get; set; } = Path;
    }
}
