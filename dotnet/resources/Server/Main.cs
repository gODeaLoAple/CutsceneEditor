using GTANetworkAPI;
using Newtonsoft.Json;
using System;

namespace Server
{
    public class Main : Script
    {
        public Main()
        {
            Console.WriteLine(JsonConvert.SerializeObject("OK"));
        }

        [ServerEvent(Event.PlayerConnected)]
        public void OnPlayerConnected(Player player)
        {
        }
    }


}
