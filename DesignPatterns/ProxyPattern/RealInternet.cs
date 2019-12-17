namespace ProxyPattern
{
    public class RealInternet : IInternet
    {
        public string ConnectTo(string serverhost) => "Connected to: " + serverhost;
    }
}
