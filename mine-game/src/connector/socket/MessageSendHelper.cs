using DotNetty.Buffers;
using DotNetty.Transport.Channels;
using mine_game.src.entity.vo;
using mine_game.src.service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using mine_game.src.common.proto;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;

namespace mine_game.src.connector.socket
{
    class MessageSendHelper
    {
        private static IChannelHandlerContext context;

        public static IChannelHandlerContext Context {set => context = value; }

        public static void SendMessage(int command, MessageBody messageBody)
        {
            common.proto.Message message = new common.proto.Message();
            message.PlayerId = (ulong)LoginService.userInfo.id;
            message.Command = command;
            message.Topic = "messageBody";
            Debug.WriteLine(context.Channel.Active);
            
            context.Channel.WriteAndFlushAsync(message.ToByteArray());
            Debug.WriteLine(message.ToString());
        }
    }
}
