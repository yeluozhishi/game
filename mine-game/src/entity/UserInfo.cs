using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace mine_game.src.entity
{
    class UserInfo
    {

        public string userName = "whk";

        public string pwd = "123";

        public int zone = 1;

        public GameGatewayInfo gameGatewayInfo { get; set; }
        public long id { get; set; }
        public string token { get; set; }

    }
}
