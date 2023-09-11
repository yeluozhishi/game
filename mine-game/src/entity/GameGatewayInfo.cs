using System;
using System.Collections.Generic;
using System.Linq;
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
        
    }
}
