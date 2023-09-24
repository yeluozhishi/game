using DotNetty.Codecs;
using DotNetty.Handlers.Logging;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using mine_game.src.entity;
using mine_game.src.entity.vo;
using mine_game.src.service;
using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace mine_game.src.connector.socket
{
    class NettyConnector
    {

        public static UserInfo userInfo;

        public static async Task RunClientAsync()
        {

            var group = new MultithreadEventLoopGroup();

            try
            {
                var bootstrap = new Bootstrap();
                bootstrap.Group(group)
                    .Channel<TcpSocketChannel>()
                    .Option(ChannelOption.TcpNodelay, true)
                    .Handler(new ActionChannelInitializer<ISocketChannel>(channel =>
                    {
                        IChannelPipeline pipeline = channel.Pipeline;
                        pipeline.AddLast(new EchoClientHandler());
                        //pipeline.AddLast(new MessageDecoder());
                        //pipeline.AddLast(new MessageEncoder());
                    }));
                await bootstrap.ConnectAsync(new IPEndPoint(LoginService.userInfo.gameGatewayInfo.Host(), LoginService.userInfo.gameGatewayInfo.port));
               
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

        }

    }
}
