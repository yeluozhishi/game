using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mine_game.src.entity.vo
{
    internal class CreatPlayerBody
    {
        private string msg;
        private string userName;
        private string serverId;

        public string Msg { get => msg; set => msg = value; }
        public string UserName { get => userName; set => userName = value; }
        public string ServerId { get => serverId; set => serverId = value; }
    }
}
