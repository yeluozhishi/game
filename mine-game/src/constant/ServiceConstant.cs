using DotNetty.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace mine_game.src.constant
{
    public static class ServiceConstant
    {
        public const string HOST = "http://127.0.0.1:5020/";

        // WEB_CENTER
        public const string WEB_CENTER = HOST + "WEB-CENTER";

        public const string WEB_CENTER_CLIENT_GET_GATE_WAY = "/user/getGameGateway";

        public const string WEB_CENTER_USER_LOGIN = "/user/login";

        public const string WEB_CENTER_USER_REGISTER = "/user/register";

        public const string WEB_CENTER_SERVER_LIST = "/server/list";

        public const string WEB_CENTER_USER_CREATE_PLAYER = "/user/createPlayer";


    }
}
