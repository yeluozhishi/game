using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mine_game.src.entity.vo
{
    [Serializable]
    class Message
    {
        public string topic { get; set; }
        public int command {  get; set; }

        public long playerId { get; set; }

        public MessageBody body { get; set; }

    }
}
