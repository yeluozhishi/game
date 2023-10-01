using DotNetty.Transport.Channels;
using mine_game.src.entity.vo;
using mine_game.src.service;
using System.Diagnostics;
using Google.Protobuf;
using DotNetty.Buffers;
using mine_game.src.common;

namespace mine_game.src.connector.socket
{
    class MessageSendHelper
    {
        private static IChannelHandlerContext context;

        public static IChannelHandlerContext Context {set => context = value; }

        public static void SendMessage(int command, object messageBody, Message.BodyOneofCase oneofCase)
        {
            Message message = MessageFactory.Instance().getMessage(command, oneofCase, messageBody);
            var body = message.ToByteArray();
            var p = Unpooled.Buffer(256);
            p.WriteBytes(body);
            context.Channel.WriteAndFlushAsync(p);
            Debug.WriteLine(message.ToString());
        }

    }
}
