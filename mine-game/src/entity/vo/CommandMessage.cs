using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mine_game.src.entity
{
    [Serializable]
    class CommandMessage
    {
        private int command;

        private String playerId;

        private MessageBody body;

        public int Command { get => command; set => command = value; }
        public string PlayerId { get => playerId; set => playerId = value; }
        internal MessageBody Body { get => body; set => body = value; }
    }
}
