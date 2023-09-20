using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace mine_game.src.body
{
    internal class GameGatewayInfo
    {
        public long id { get; set; }
        public string ip { get; set; }
        public int port { get; set; }
        public string instanceId { get; set; }
        public int zone { get; set; }

        public IPAddress Host() 
        {
            if (ip != null)
            {
                return IPAddress.Parse(ip);
            } else
            {
                return IPAddress.Parse("127.0.0.1");
            }
        }
        
    }
}
