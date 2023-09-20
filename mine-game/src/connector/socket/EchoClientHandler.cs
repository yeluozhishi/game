using DotNetty.Buffers;
using DotNetty.Transport.Channels;
using mine_game.src.common;
using System;
using System.Diagnostics;
using System.Text;

namespace mine_game.src.connector.socket
{
    class EchoClientHandler : ChannelHandlerAdapter
    {
        readonly private IByteBuffer initialMessage;
        public EchoClientHandler()
        {
            this.initialMessage = Unpooled.Buffer(256);
            byte[] messageBytes = Encoding.UTF8.GetBytes("Hello world");
            this.initialMessage.WriteBytes(messageBytes);
        }

        public override void ChannelActive(IChannelHandlerContext context) => context.WriteAndFlushAsync(this.initialMessage);

        public override void ChannelRead(IChannelHandlerContext context, object message)
        {
            var byteBuffer = message as IByteBuffer;
            if (byteBuffer != null)
            {
                Debug.WriteLine("Received from server: " + byteBuffer.ToString(Encoding.UTF8));
            }
            context.WriteAsync(message);
        }

        public override void ChannelReadComplete(IChannelHandlerContext context) => context.Flush();

        public override void ExceptionCaught(IChannelHandlerContext context, Exception exception)
        {
            Debug.WriteLine("Exception: " + exception);
            context.CloseAsync();
        }
    }
}
