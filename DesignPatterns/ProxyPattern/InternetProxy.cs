using System;
using System.Collections.Generic;

namespace ProxyPattern
{
    public class InternetProxy : IInternet
    {
        private readonly IInternet _internet = new RealInternet();
        private static readonly List<string> BannedSites = new List<string>
            {"abc.com", "def.com", "ghi.com", "jkl.com", "mno.com"};
        public string ConnectTo(string serverhost)
        {
            if (BannedSites.Contains(serverhost.ToLower())) throw new Exception("Access Denied");
            return _internet.ConnectTo(serverhost);
        }
    }
}
