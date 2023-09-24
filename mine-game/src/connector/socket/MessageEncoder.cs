using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Common.Utilities;
using DotNetty.Transport.Channels;
using mine_game.src.entity.vo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Windows.System;

namespace mine_game.src.connector.socket
{
    class MessageEncoder : MessageToByteEncoder<Message>
    {

        protected override void Encode(IChannelHandlerContext context, Message message, IByteBuffer output)
        {
            BinaryFormatter serializer = new BinaryFormatter();

            MemoryStream memStream = new MemoryStream();

            serializer.Serialize(memStream, message);
            //var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message));
            var body = memStream.ToArray();
            int dataLength = body.Length;
            output.WriteInt(dataLength);
            output.WriteBytes(body);
        }

    }
}
