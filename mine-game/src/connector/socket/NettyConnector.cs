using DotNetty.Codecs;
using DotNetty.Handlers.Logging;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using mine_game.src.service;
using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace mine_game.src.connector.socket
{
    class NettyConnector
    {

        public static IChannel clientChannel = null;
        static async Task RunClientAsync()
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
                        pipeline.AddLast(new LoggingHandler());
                        pipeline.AddLast("framing-enc", new LengthFieldPrepender(2));
                        pipeline.AddLast("framing-dec", new LengthFieldBasedFrameDecoder(ushort.MaxValue, 0, 2, 0, 2));

                        pipeline.AddLast("echo", new EchoClientHandler());


                    }));
                clientChannel = await bootstrap.ConnectAsync(new IPEndPoint(LoginService.userInfo.gameGatewayInfo.Host(), LoginService.userInfo.gameGatewayInfo.port));
                Debug.WriteLine("建立连接");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                await group.ShutdownGracefullyAsync(TimeSpan.FromMilliseconds(100), TimeSpan.FromSeconds(1));
            }

        }

        public static void Run() => RunClientAsync().Wait();


        public void sendMessage()
        {


            clientChannel.WriteAndFlushAsync(new byte[0]);
        }
    }
}
